using _3BPACS.Domain.Entities;
using _3BPACS.Domain.Interfaces;
using ApiAuth.Infrastructure.Data;

namespace ApiAuth.Infrastructure.Repository
{

    public class UsuarioRepository : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }


    }

}