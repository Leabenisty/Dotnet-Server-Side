namespace Web_API.Core.Models
{
    public class Workhours
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int HoursDay { get; set; }
        public int EmployeeId { get; set; }

        public Employee employees;

        //Employee ID
        //This is a record
        //date day /month/year
        //a few hours
    }
}
