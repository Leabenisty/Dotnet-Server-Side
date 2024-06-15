using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core.Repositories
{
    public interface ISalaryRepository
    {
        Task<IEnumerable<Salary>> GetAllAsync();
        Task<Salary> GetByIdAsync(int id);
        Task<Salary> PostAsync(Salary salary);
        Task<Salary> PutAsync(Salary salary, int id);
        Task<Salary> PutStatusAsync(int id, bool Paidup);
    }
}
