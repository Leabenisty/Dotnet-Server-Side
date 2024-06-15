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
    public class WorkhoursRepository : IWorkhoursRepository
    {
     
        private readonly DataContext _dataContext;
        public WorkhoursRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Workhours>> GetWorkhoursAsync()
        {
            return await _dataContext.DataWorkhours.ToListAsync();// Include(e=>e._employees);
        }
        public async Task<Workhours> GetByIdAsync(int id)
        {
            Workhours w = await _dataContext.DataWorkhours.FirstAsync(e => e.Id == id);
            return w;
        }

        public async Task<Workhours> PostAsync(Workhours workhours)
        {
            _dataContext.DataWorkhours.Add(new Workhours { EmployeeId = workhours.EmployeeId, Day = workhours.Day, Month = workhours.Month, Year = workhours.Year, HoursDay = workhours.HoursDay });
            await _dataContext.SaveChangesAsync();
            return workhours;
        }

        public async Task<Workhours> PutAsync(Workhours workhours, int id)
        {
            Workhours w = _dataContext.DataWorkhours.Find(id);
            if (w != null)
            {             
                w.EmployeeId = workhours.EmployeeId;
                w.Day = workhours.Day;
                w.Month = workhours.Month;
                w.Year = workhours.Year;
                w.HoursDay = workhours.HoursDay;

            }
            await _dataContext.SaveChangesAsync();
            return w;
        }
    }
}
