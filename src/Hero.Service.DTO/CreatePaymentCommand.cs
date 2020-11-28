using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class CreatePaymentCommand
    {
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public bool IsFinal { get; set; }
        public string PaxId { get; set; }
    }

    public enum PaymentMethod
    {
        Cash = 1,
        CreditCard = 2,
        BankTransfer = 3,
        FOC = 4
    }
}
