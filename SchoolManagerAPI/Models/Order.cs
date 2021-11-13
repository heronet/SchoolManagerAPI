using System;

namespace SchoolManagerApi.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public bool Delivered { get; set; } = false;
        public long OrderedItemsCount { get; set; } = 0;
        public long DeliveredItemsCount { get; set; } = 0;
        public double TotalPrice { get; set; } = 0;
        public int RoomNumber { get; set; }
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public EntityUser User { get; set; }
        public string DeliveryMan { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(6.00);
    }
}