namespace BuildComp_Database.Models.DTO
{
    public class MotherboardDTO
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public string? socketType { get; set; }
        public string? gpuPort { get; set; }
        public string? ramType {get; set; }
        public int? ramMax {get; set; }
        public int? memorySlots {get; set;}
        public string? chipset {get; set; }
        public int? PCIESlotNumber {get; set; }
    }
}