using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;
namespace Solid.Core.Repositories
{
    public interface IWorkhoursRepository
    {
        Task<IEnumerable<Workhours>> GetWorkhoursAsync();

        Task<Workhours> GetByIdAsync(int id);

        Task<Workhours> PostAsync(Workhours workhours);

        Task<Workhours> PutAsync(Workhours workhours, int id);


    }
}
