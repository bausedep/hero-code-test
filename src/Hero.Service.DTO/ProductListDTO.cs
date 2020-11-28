using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class ProductListDTO
    {
        public double SearchTime { get; set; }
        public int NumberResults { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}
