namespace _3BPACS.Domain.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; private set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }


        public UsuarioEntity(string nomeUsuario, string senha) { 
            NomeUsuario = nomeUsuario;
            Senha = senha;  
        }

        public UsuarioEntity(int id, string nomeUsuario, string senha)
        {
            Id = id;
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }

}
