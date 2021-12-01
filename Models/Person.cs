using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("People")]
    public class Person
    {
        [DisplayName("Mã")]
        public string PersonID { get; set; }
        [DisplayName("Tên người")]
        public string PersonName { get; set; }
        
    }
}
