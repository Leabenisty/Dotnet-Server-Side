using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core.Services
{
    public interface ISalaryService
    {
        Task<IEnumerable<Salary>> GetAllAsync();
        Task<Salary> GetByIdAsync(int id);
        Task<Salary> PostAsync(Salary salary);
        Task<Salary> PutAsync(int id, Salary salary);
        Task<Salary> PutStatusAsync(int id, bool Paidup);



    }
}
