using _3BPACS.Common.DTOs;
using _3BPACS.Common.ViewModels;
using _3BPACS.Domain.Services;
using AutoMapper;

namespace _3BPACS.Application
{
    public class ExamOrderAppService
    {
        private readonly ExamOrderDomainService _examOrderDomainService;
        private readonly IMapper _mapper;

        public ExamOrderAppService(ExamOrderDomainService examOrderDomainService, IMapper mapper)
        {
            _examOrderDomainService = examOrderDomainService;
            _mapper = mapper;
        }

        public ExamOrderDto CreateExamOrder(ExamOrderViewModel examOrderViewModel)
        {
            var examOrderDto = _mapper.Map<ExamOrderDto>(examOrderViewModel);
            return _examOrderDomainService.CreateExamOrder(examOrderDto);
        }

    }

}