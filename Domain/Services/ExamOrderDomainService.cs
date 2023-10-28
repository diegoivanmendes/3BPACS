using _3BPACS.Common.DTOs;
using _3BPACS.Domain.Entities;
using _3BPACS.Domain.Interfaces;

namespace _3BPACS.Domain.Services
{
    public class ExamOrderDomainService
    {
        private readonly IExamOrderRepository _examOrderRepository;

        public ExamOrderDomainService(IExamOrderRepository examOrderRepository)
        {
            _examOrderRepository = examOrderRepository;
        }

        public ExamOrderDto CreateExamOrder(ExamOrderDto examOrderDto)
        {
            try
            {
                var examOrder = new ExamOrder(examOrderDto.PatientName, examOrderDto.ExamType);
                _examOrderRepository.AddAsync(examOrder).Wait();  // Note: Added .Wait() to await the async call
                return new ExamOrderDto { Id = examOrder.Id, PatientName = examOrder.PatientName, ExamType = examOrder.ExamType };
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework like Serilog or NLog)
                // For example: _logger.LogError(ex, "Error creating exam order");

                // Optionally, re-throw the exception or return a default value
                throw;  // Re-throws the original exception

                // OR

                // return null;  // Returns null to indicate failure
            }
        }

        public List<ExamOrderDto> GetAllExamOrders()
        {
            var examOrders = _examOrderRepository.GetAllAsync().Result;
            return examOrders.Select(eo => new ExamOrderDto { Id = eo.Id, PatientName = eo.PatientName, ExamType = eo.ExamType }).ToList();
        }


    }

}