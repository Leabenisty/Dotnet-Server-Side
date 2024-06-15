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
    public class WorkhoursService:IWorkhoursService
    {
        private readonly IWorkhoursRepository _workhoursRepository;
        public WorkhoursService(IWorkhoursRepository workhoursRepository)
        {
            _workhoursRepository = workhoursRepository;
        }
        public async Task<IEnumerable<Workhours>> GetWorkhoursAsync()
        {
            return await _workhoursRepository.GetWorkhoursAsync();
        }

        public async Task<Workhours> GetByIdAsync(int id)
        {
           return await _workhoursRepository.GetByIdAsync(id);        
        }
    
        public async Task<Workhours> PostAsync(Workhours workhours)
        {
            return await _workhoursRepository.PostAsync(workhours);
        }

        public async Task<Workhours> PutAsync(Workhours workhours, int id)
        {
            return await _workhoursRepository.PutAsync(workhours,id);           
        }
    }
}
