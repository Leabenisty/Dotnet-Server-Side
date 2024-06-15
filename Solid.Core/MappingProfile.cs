using AutoMapper;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            CreateMap<Salary,SalaryDto>().ReverseMap();
            CreateMap<Workhours,WorkhoursDto>().ReverseMap();
        }
    }
}
