using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ListApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int quantity { get; set; }
        public string observacao { get; set; }
        public string imagePath { get; set; }
        public string adicionais { get; set; }
        public string menuId { get; set; }

        // Foreign key
        public int order_id { get; set; }

        // Navigation property
        [ForeignKey("order_id")]
        [JsonIgnore]  // Ignorar durante a serialização
        public Order? Order { get; set; }
    }
}
