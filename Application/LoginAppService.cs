using _3BPACS.Common.DTOs;
using _3BPACS.Common.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace _3BPACS.Application;

public class LoginAppService
{

    /// <summary>
    /// Método resposável por autenticar o usuário da aplicação.
    /// </summary>
    /// <param name="loginViewModel"></param>
    /// <returns></returns>
    public async Task<UsuarioAutenticadoDto> Autenticar(LoginViewModel loginViewModel)
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52379/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(
                    "login", loginViewModel);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            UsuarioAutenticadoDto? usuarioAutenticadoDto = await response.Content.ReadFromJsonAsync<UsuarioAutenticadoDto>();
            return usuarioAutenticadoDto;
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
