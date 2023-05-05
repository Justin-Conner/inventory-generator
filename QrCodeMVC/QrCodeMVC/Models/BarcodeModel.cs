namespace QrCodeMVC.Models
{
    public class BarcodeModel
    {
        public int Id { get; set; }
        public string BarcodeData { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        public string BarcodeImagePath { get; set; }
    }
}
