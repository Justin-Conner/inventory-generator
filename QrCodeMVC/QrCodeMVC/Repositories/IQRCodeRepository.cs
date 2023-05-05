using System.Collections.Generic;
using QrCodeMVC.Models;

namespace QrCodeMVC.Repositories
{
    public interface IQRCodeRepository
    {
        IEnumerable<QRCodeModel> QRCodes { get; }
        void AddQRCode(QRCodeModel qrCode);
        QRCodeModel GetQRCodeById(int qrCodeId);
        IEnumerable<QRCodeModel> GetAll();
    }
}
