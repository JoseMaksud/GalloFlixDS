using System.ComponentModel.DataAnnotations;

namespace GalloFlix.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuiir no máximo 30 caracteres")]
    public string Name { get; set; }


    [Display(Name = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe a Data de Nascimento")]
    public DateTime Birthday { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirme sua senha")]
    [Required(ErrorMessage = "Por favor, confirme sua senha")]
    public string ConfirmPassword { get; set; }
}
