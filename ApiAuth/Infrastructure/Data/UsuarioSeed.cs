using _3BPACS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAuth.Infrastructure.Data;

public static class UsuarioSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UsuarioEntity>().HasData(
            new UsuarioEntity(1, "Alisson", "123456"),
            new UsuarioEntity(2, "Diego", "123456"),
            new UsuarioEntity(3, "Vinicius", "123456")
        );

    }
}
