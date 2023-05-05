
using QrCodeMVC.Models;

namespace QrCodeMVC.ViewModels
{
    public class QRCodeViewModel
    {
        public IEnumerable<QRCodeModel> QRCodeModels { get; set; }
        public IEnumerable<BarcodeModel> BarcodeModels { get; set; }
    }
}


/*  The ViewModels file is named ScanResultViewModel.cs and it contains a single property called ScanResult that will be used to display the result of the barcode or QR code scan in the Read.cshtml view. Note that the Display attribute is used to give the property a user-friendly display name. */