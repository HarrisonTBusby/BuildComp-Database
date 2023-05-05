namespace BuildComp_Database.Models
{
    public class PsModel
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
        public double? wattage {get; set; }
        public string? color {get; set; }
        public int? EPS8ConnectorNum {get; set; }
        public int? PCIe62ConnectorNum{get; set;}
        public int? PCIe6ConnectorNum{get; set; }
        public int? SataConnectors {get; set; }
        public int? Molex4ConnectorNum {get; set;}

    }
}