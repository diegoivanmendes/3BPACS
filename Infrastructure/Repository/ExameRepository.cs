using _3BPACS.Domain.Interfaces;
using _3BPACS.Domain.Entities;
using _3BPACS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using _3BPACS.Infrastructure.Data;

namespace _3BPACS.Repository
{
    public class ExamOrderRepository : BaseRepository<ExamOrder>, IExamOrderRepository
    {
        public ExamOrderRepository(ApplicationDbContext context) : base(context) { }


    }

}