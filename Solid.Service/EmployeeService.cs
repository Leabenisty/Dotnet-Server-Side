using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Service
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepositoy;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {

            _employeeRepositoy = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepositoy.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeRepositoy.GetByIdAsync(id);         
        }
        public async Task<Employee> PostAsync(Employee employee)
        {
            return await _employeeRepositoy.PostAsync(employee);        
        }

        public async Task< Employee> PutAsync(int id,Employee employee)
        {        
             return await _employeeRepositoy.PutAsync(employee,id);           
        }
        public async Task Delete(int id)
        {
           await _employeeRepositoy.Delete(id);                 
        }
      
    }
}
