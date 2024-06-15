using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;


namespace Solid.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
       
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dataContext.DataEmployee.ToListAsync();//Include(e=>e.Salary).Include(e => e.WorkHours);
        }
        public async Task<Employee> GetByIdAsync(int id)
        {

            Employee e = await _dataContext.DataEmployee.FirstAsync(e=>e.Id==id);
            return e;
        }

        public async Task<Employee> PutAsync(Employee employee, int id)
        {

            Employee e = _dataContext.DataEmployee.Find( id);

            e.Firstname = employee.Firstname;
            e.Lastname = employee.Lastname;
            e.Age = employee.Age;
            await _dataContext.SaveChangesAsync();
            return e;
        }

        public async Task <Employee> PostAsync(Employee employee)
        {
           _dataContext.DataEmployee.Add(new Employee { Firstname = employee.Firstname, Lastname = employee.Lastname, Age = employee.Age });
           await _dataContext.SaveChangesAsync ();
            return employee;
        }


        public async Task Delete(int id)
        {
            var e = _dataContext.DataEmployee.Find(id);
            if(e != null)
                _dataContext.DataEmployee.Remove(e);
            await _dataContext.SaveChangesAsync();
        }

       
    }
}
