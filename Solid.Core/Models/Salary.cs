namespace Web_API.Core.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public double Basesalary { get; set; }
        public  double Bouns { get; set; }

        public  double Finalesalary { get; set; }
        public bool Paidup { get ; set  ; }
        public int EmployeeId { get; set; }

        public Employee employees { get; set; }


        //Record ID and Employee ID
        //month and year
        //Amount of how many hours per month and bonus

    }
}
