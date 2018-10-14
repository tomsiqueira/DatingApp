using System.ComponentModel.DataAnnotations;
using DatingApp.API.Util;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(Util_Validacao.comprimentoMaximoStringSenha, MinimumLength = Util_Validacao.comprimentoMinimoStringSenha, ErrorMessage=Util_Mensagem.invalidPassword)]
        public string Password { get; set; }
    }
}