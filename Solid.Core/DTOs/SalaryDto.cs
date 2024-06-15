using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class SalaryDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public double Basesalary { get; set; }
        public double Bouns { get; set; }

        public double Finalesalary { get; set; }
        public bool Paidup { get; set; }
    }
}
