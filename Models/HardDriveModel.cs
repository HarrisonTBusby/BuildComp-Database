namespace BuildComp_Database.Models
{
    public class HardDriveModel
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public double? storageCapacity {get; set;}
        public string? PCIeType {get; set; }
        
    }
}