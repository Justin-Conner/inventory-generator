using QrCodeMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace QrCodeMVC.ViewModels
{
    public class ScanResultViewModel
    {
        [Display(Name = "Scan Result")]
        public string ScanResult { get; set; }

        public IEnumerable<QRCodeModel> QRCodeModels { get; set; }
        public IEnumerable<BarcodeModel> BarcodeModels { get; set; }
    }
}
