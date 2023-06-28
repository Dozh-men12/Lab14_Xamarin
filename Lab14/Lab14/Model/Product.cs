using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14.Model
{
    public class Product

    {
        public int ProductsId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }

    }
}
