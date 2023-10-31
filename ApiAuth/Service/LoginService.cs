using _3BPACS.Domain.Entities;
using _3BPACS.Domain.Interfaces;
using ApiAuth.Models;
using Domain.Interfaces;
using System.Linq;

namespace ApiAuth.Service
{
    /// <summary>
    /// Classe resposável pelo serviço de Login.
    /// </summary>
    public class LoginService : ILoginService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public LoginService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        /// <summary>
        /// Método responsável por autenticar o usuário.
        /// </summary>
        /// <param name="credencial"></param>
        /// <returns>Retorno o objeto Usuario</returns>
        public Usuario Autentica(Credencial credencial)
        {
            
            //Retornar os usuários cadastrados.
            var usuarios = _usuarioRepository.GetAllAsync().Result.ToList();

            //Verifica se o usuário e senha digitado contém na lista de usuários.
            var usuario = usuarios.SingleOrDefault(x => x.NomeUsuario.Equals(credencial.Usuario) && x.Senha.Equals(credencial.Senha));

            return new Usuario
            {
                Nome = usuario.NomeUsuario,
                Role = "Admin"
            };

        }

    }
}
