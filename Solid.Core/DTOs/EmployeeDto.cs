using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDto
    {
        public int Id { get ; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set ; }
        public int Age { get; set ; }
    }
}
