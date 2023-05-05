namespace BuildComp_Database.Models.DTO
{
    public class GpuDTO
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public string? socketType { get; set; }
        public int? memory { get; set; }
        public double? perfCoreClock {get; set;}
        public string? chipset { get; set; }
    }
}