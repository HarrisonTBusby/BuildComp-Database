using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BuildComp_Database.Models
{
    
    public class WishlistItemModel
    {
        public int id { get; set; }
        public string? Username {get; set;}
        public string? title { get; set; }
        public string? price { get; set; }
        public string? image_url { get; set; }
        public string? item_url { get; set; }
        public string? type { get; set; }

        public WishlistItemModel(){}
    }
}