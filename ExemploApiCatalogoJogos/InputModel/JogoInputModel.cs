using System.ComponentModel.DataAnnotations;

namespace ExemploApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 30 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 e 30 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }
    }
}
