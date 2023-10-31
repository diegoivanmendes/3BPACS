using ApiAuth.Models;

namespace Domain.Interfaces
{
    public interface ILoginService
    {
        Usuario Autentica(Credencial credencial);
    }
}
