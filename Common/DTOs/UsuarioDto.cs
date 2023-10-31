namespace _3BPACS.Common.DTOs;

public class UsuarioDto
{
    public string Nome { get; set; }
    public string Role { get; set; }
}

public class UsuarioAutenticadoDto
{
    public string Token { get; set; }
    public UsuarioDto Usuario { get; set; }
}