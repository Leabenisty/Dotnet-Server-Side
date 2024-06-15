using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core.DTOs
{
    public class WorkhoursDto
    {
        public int Id { get; set; }       
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int HoursDay { get; set; }
        public int EmployeeId { get; set; }

        public Employee employees;
    }
}
