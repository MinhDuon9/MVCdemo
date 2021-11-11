using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Student
    {
        [DisplayName("Số")]
        public string StudentId { get; set; }
        [DisplayName("Tên sinh viên")]
        public string StudentName { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        
    }
}
