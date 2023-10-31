namespace ApiAuth.Domain.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; private set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }

}
