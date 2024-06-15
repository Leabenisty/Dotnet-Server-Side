using Solid.Core.Repositories;
using Solid.Core.Services;
//using Solid.Data.Repositories;
using Web_API.Core.Models;

namespace Solid.Service
{
    public class SalaryService:ISalaryService
    {
        private readonly ISalaryRepository _salaryRepository;
        public SalaryService(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task<IEnumerable<Salary>> GetAllAsync()
        {
            return await _salaryRepository.GetAllAsync();
        }

        public async Task<Salary> GetByIdAsync(int id)
        {
            return await _salaryRepository.GetByIdAsync(id);         
        }

        public async Task<Salary> PostAsync(Salary salary)
        {
           return await _salaryRepository.PostAsync(salary);
        }

        public async Task<Salary> PutAsync(int id, Salary salary)
        {      
           return await _salaryRepository.PutAsync(salary, id);            
        }

        public async Task<Salary> PutStatusAsync(int id, bool Paidup)
        {
           return await _salaryRepository.PutStatusAsync(id, Paidup);
        }
    }
}