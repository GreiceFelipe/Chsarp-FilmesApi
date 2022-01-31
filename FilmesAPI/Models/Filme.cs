using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; internal set; }

        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório.")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genero deve ter tamanho máx 30")]
        public string Genero { get; set; }

        [Range(1,600, ErrorMessage = "A duração deve ter no min 1 e no máx 600 min.")]
        public int Duracao { get; set; }
    }
}
