using System;
using System.Collections.Generic;
using System.Linq;
using QrCodeMVC.Models;
using QrCodeMVC.Repositories;

namespace QrCodeMVC.Data
{
    public static class SampleData
    {
        public static void Initialize(IQRCodeRepository qrCodeRepo)
        {
            if (!qrCodeRepo.QRCodes.Any())
            {
                var qrCodes = new List<QRCodeModel>
                {
                    new QRCodeModel
                    {
                        QRCodeText = "Sample QR Code 1",
                        QRCodeImagePath = "/images/sample-qrcode-1.png",
                        CreatedDate = DateTime.Now
                    },
                    new QRCodeModel
                    {
                        QRCodeText = "Sample QR Code 2",
                        QRCodeImagePath = "/images/sample-qrcode-2.png",
                        CreatedDate = DateTime.Now
                    }
                };

                foreach (var qrCode in qrCodes)
                {
                    qrCodeRepo.AddQRCode(qrCode);
                }
            }
        }
    }
}
