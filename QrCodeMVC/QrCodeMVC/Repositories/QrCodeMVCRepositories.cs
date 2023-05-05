using System;
using System.Collections.Generic;
using System.Linq;
using QrCodeMVC.Data;
using QrCodeMVC.Models;

namespace QrCodeMVC.Repositories
{
    public class QrCodeMVCRepositories : IQRCodeRepository, IBarcodeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public QrCodeMVCRepositories(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<QRCodeModel> QRCodes => _dbContext.QRCodes;

        public void AddQRCode(QRCodeModel qrCode)
        {
            _dbContext.QRCodes.Add(qrCode);
            _dbContext.SaveChanges();
        }

        public QRCodeModel GetQRCodeById(int qrCodeId) => _dbContext.QRCodes.FirstOrDefault(q => q.Id == qrCodeId);

        public IEnumerable<BarcodeModel> Barcodes => _dbContext.Barcodes;

        public void AddBarcode(BarcodeModel barcode)
        {
            _dbContext.Barcodes.Add(barcode);
            _dbContext.SaveChanges();
        }

        public BarcodeModel GetBarcodeById(int barcodeId) => _dbContext.Barcodes.FirstOrDefault(b => b.Id == barcodeId);

        public IEnumerable<QRCodeModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
/*This file includes two interfaces (IQRCodeRepository and IBarcodeRepository) with methods for adding codes, getting codes by ID, and accessing all codes. The QrCodeMVCRepositories class implements both interfaces and provides the actual implementation for the methods using an instance of AppDbContext. */