using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();

        Task<Employee> GetByIdAsync(int id);

        Task<Employee> PutAsync(Employee employee, int id);

        Task<Employee> PostAsync(Employee employee);

        Task Delete(int id);
       
    }
}
