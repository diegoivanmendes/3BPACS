﻿using _3BPACS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3BPACS.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExamOrder> ExamOrders { get; set; }

    }
}
