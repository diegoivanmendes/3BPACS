using System.ComponentModel.DataAnnotations;

namespace _3BPACS.Common.ViewModels;

public class LoginViewModel
{
    [Display(Name = "Usuario")]
    public string Usuario { get; set; }

    [Display(Name = "Senha")]
    public string Senha { get; set; }
}
