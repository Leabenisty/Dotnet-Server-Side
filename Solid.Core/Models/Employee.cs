namespace Web_API.Core.Models
{
    public class Employee
    { 
        public int Id { get; set ; } 
        public string Firstname { get ; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }          
        public List<Salary > Salary { get; set; }    
        public List<Workhours> WorkHours { get; set; }
    
        

       
    }
}
