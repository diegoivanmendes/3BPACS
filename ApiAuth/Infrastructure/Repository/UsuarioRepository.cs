
using ApiAuth.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using ApiAuth.Infrastructure.Data;
using _3BPACS.Domain.Interfaces;
using _3BPACS.Domain.Entities;

namespace ApiAuth.Infrastructure.Repository
{
    
    public class UsuarioRepository : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }


    }

}