using _3BPACS.Common.DTOs;
using _3BPACS.Common.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BPACS.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExamOrderViewModel, ExamOrderDto>();
            // ... (outros mapeamentos)
        }
    }

}
