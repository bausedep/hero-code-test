using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class CreateBookingCommandItem
    {

        public int ProductId { get; set; }
        public string DateCheckIn { get; set; }
        public int Nights { get; set; }
        public ICollection<string> PaxId { get; set; }
        public string AgentReference { get; set; }
        public string SupplierReference { get; set; }
        public string VoucherNotes { get; set; }
        public string Pickup { get; set; }
        public decimal Rrp { get; set; }
        //public List<PaxRoomId> PaxRoomId { get; set; }
        public string Status { get; set; }
        public CreateBookingCommandItem()
        {
            PaxId = new List<string>();
        }
    }

    public class CreateBookingCommand
    {
        public string Name { get; set; }
        public ICollection<CreateBookingCommandItem> BookingProducts { get; set; }
        public CreateBookingCommand()
        {
            BookingProducts = new List<CreateBookingCommandItem>();
        }
    }
}
