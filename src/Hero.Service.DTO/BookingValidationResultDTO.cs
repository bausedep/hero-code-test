using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class BookingValidationResultDTO
    {

        public bool IsValid { get; set; }
        public ICollection<string> Errors { get; set; }

        public BookingValidationResultDTO()
        {
            Errors = new List<string>();
        }
    }
}
