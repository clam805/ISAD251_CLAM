using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MushroomTeaHouse.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual List<OrderItem> OrderItem { get; set; }
    }
}
