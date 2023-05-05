using Microsoft.AspNetCore.Mvc;
using QrCodeMVC.Models;
using QrCodeMVC.Repositories;
using QrCodeMVC.ViewModels;

namespace QrCodeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQRCodeRepository _qrCodeRepository;
        private readonly IBarcodeRepository _barcodeRepository;

        public HomeController(IQRCodeRepository qrCodeRepository, IBarcodeRepository barcodeRepository)
        {
            _qrCodeRepository = qrCodeRepository;
            _barcodeRepository = barcodeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateQRCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateQRCode(QRCodeModel qrCode)
        {
            if (ModelState.IsValid)
            {
                _qrCodeRepository.AddQRCode(qrCode);
                TempData["Message"] = "QR Code created successfully";
                return RedirectToAction("Index");
            }
            return View(qrCode);
        }

        [HttpGet]
        public IActionResult CreateBarcode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBarcode(BarcodeModel barcode)
        {
            if (ModelState.IsValid)
            {
                _barcodeRepository.AddBarcode(barcode);
                TempData["Message"] = "Barcode created successfully";
                return RedirectToAction("Index");
            }
            return View(barcode);
        }

        public IActionResult Read()
        {
            var qrCodes = _qrCodeRepository.QRCodes;
            var barcodes = _barcodeRepository.Barcodes;
            var qrCodeViewModel = new QRCodeViewModel
            {
                QRCodeModels = qrCodes,
                BarcodeModels = barcodes
            };
            return View(qrCodeViewModel);
        }
    }
}
