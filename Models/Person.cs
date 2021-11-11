using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Person
    {
        [DisplayName("Số")]
        public string PersonID { get; set; }
        [DisplayName("Tên người")]
        public string PersonName { get; set; }
        
    }
}
