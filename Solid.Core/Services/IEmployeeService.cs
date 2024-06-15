using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task<Employee> PutAsync(int id, Employee employee);
        Task<Employee> PostAsync(Employee employee);
        Task Delete(int id); 
    }
}
