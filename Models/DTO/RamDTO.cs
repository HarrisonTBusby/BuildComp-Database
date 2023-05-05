namespace BuildComp_Database.Models.DTO
{
    public class RamDTO
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public string? color {get; set;}
        public string? typeSpeed {get; set;}
        public string? moduleAmount {get;set;}
        public double? firstWordLatency {get; set; }
    }
}