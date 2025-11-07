using EventManagement.Models.Common;
using EventManagement.Models.EventModels;
using System.Collections.Generic;

namespace EventManagement.Models.EventModels
{
    /// <summary>
    /// TicketType, bir etkinlikteki bilet türünü temsil eder (örneğin VIP, Standard, Student).
    /// </summary>
    public class TicketType : BaseEntity
    {
        // 🔹 Bilet tipi adı
        public string Name { get; set; } = "";

        // 🔹 Açıklama
        public string? Description { get; set; }

        // 🔹 Fiyat
        public decimal Price { get; set; }

        // 🔹 Toplam bilet kapasitesi (örnek: 200)
        public int TotalQuantity { get; set; }

        // 🔹 Bir kişi maksimum kaç bilet alabilir (örnek: 3)
        public int MaxPerPerson { get; set; } = 1;

        // 🔹 Satılan bilet sayısı
        public int SoldCount { get; set; } = 0;

        // 🔹 İlişkiler
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        public ICollection<TicketPurchase> Purchases { get; set; } = new List<TicketPurchase>();
    }
}
