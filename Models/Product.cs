using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Product
    {
        [DisplayName("Số")]
        public string ProductID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Giá")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
