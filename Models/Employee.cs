using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Employee
    {
        [DisplayName("Số")]
        public string EmployeeID { get; set; }
        [DisplayName("Tên Nhân viên")]
        public string EmployeeName { get; set; }
        [DisplayName("Số Điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
