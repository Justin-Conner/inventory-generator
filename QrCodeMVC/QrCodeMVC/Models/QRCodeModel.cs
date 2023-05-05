namespace QrCodeMVC.Models
{
    public class QRCodeModel
    {
        public int Id { get; set; }
        public string QRCodeText { get; set; }
        public string QRCodeImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
