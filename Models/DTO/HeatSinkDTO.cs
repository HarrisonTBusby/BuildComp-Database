namespace BuildComp_Database.Models.DTO
{
    public class HeatsinkDTO
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public string? color {get; set; }
        public string? fanRPM {get; set; }
        public double? fanNoise {get; set; }
        public bool isWaterCooled {get; set; }

    }

}