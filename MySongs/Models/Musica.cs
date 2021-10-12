using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    [Table("Musicas")] // define o nome da tabela
    public class Musica
    {
        [Key] // define chave primaria
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar a musica!")]

        public string Nome { get; set; }

        [Display(Name = "Duração")]
        [Required(ErrorMessage = "Obrigatório informar a duração!")]

        public TimeSpan Duracao { get; set; }

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "Obrigatório informar a data de lançamento!")]

        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Obrigatório informar o gênero!")]

        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")] // define chave estrangeira
        public Genero Genero { get; set; }
    }
}
