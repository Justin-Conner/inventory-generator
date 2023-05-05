using System.Collections.Generic;
using QrCodeMVC.Models;

namespace QrCodeMVC.Repositories
{
    public interface IBarcodeRepository
    {
        IEnumerable<BarcodeModel> Barcodes { get; }
        void AddBarcode(BarcodeModel barcode);
        BarcodeModel GetBarcodeById(int barcodeId);
    }
}
