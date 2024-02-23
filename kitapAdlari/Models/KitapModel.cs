using System.Reflection.Metadata.Ecma335;

namespace kitapAdlari.Models
{
    public class KitapModel
    {
        public int KitapId { get; set; }
        public string? KitapAdi { get; set; }
        public int sayfaSayisi { get; set; }
        public string? yazari { get; set; }
        public string? turu { get; set; }
    }
}
