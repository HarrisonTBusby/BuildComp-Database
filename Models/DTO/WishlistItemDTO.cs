namespace BuildComp_Database.Models.DTO
{
    public class WishlistItemDTO
    { 
        public int id { get; set; }
        public string? Username {get; set;}
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }
    }
}