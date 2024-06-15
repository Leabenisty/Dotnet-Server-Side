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
    public class SalaryRepository : ISalaryRepository
    {
        
        private readonly DataContext _dataContext;
        public SalaryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    
        public async Task<IEnumerable<Salary>> GetAllAsync()
        {
            return await _dataContext.DataSalary.ToListAsync(); ;// Include(e=>e._employees);
        }

        public async Task<Salary> GetByIdAsync(int id)
        {
            Salary s = await _dataContext.DataSalary.FirstAsync(e => e.Id == id);
            return s;
        } 
        public async Task<Salary> PostAsync(Salary salary)
        {
            _dataContext.DataSalary.Add( new Salary {EmployeeId = salary.EmployeeId,Month = salary.Month,Year = salary.Year,Basesalary = salary.Basesalary,
             Bouns = salary.Bouns, Finalesalary = salary.Finalesalary,Paidup = salary.Paidup});
            await _dataContext.SaveChangesAsync();
             return salary;
        }
        public async Task<Salary> PutAsync(Salary salary, int id)
        {
            Salary s = _dataContext.DataSalary.Find(id);
            if (s != null) 
            { 
                        
                s.EmployeeId = salary.EmployeeId;
                s.Month = salary.Month;
                s.Year = salary.Year;
                s.Basesalary = salary.Basesalary;
                s.Bouns = salary.Bouns;
                s.Finalesalary = salary.Finalesalary;
                s.Paidup = salary.Paidup;
            }
            await _dataContext.SaveChangesAsync();
            return s;
            
        }

        public async Task<Salary> PutStatusAsync(int id, bool Paidup)
        {
            Salary s = _dataContext.DataSalary.Find(id);
            if(s!=null)
                s.Paidup=Paidup;
           await _dataContext.SaveChangesAsync();
            return s;
           
        }
    }

       

       
    
}
