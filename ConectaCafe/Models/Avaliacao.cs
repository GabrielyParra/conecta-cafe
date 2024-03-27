using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliação")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por Favor, Informe o nome da pessoa")]
    [StringLength(60,ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Pessoa { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "Por Favor, Informe o título")]
    [StringLength(100,ErrorMessage = "O título deve possuir no máximo 500 caracteres")]
    public String Titulo { get; set; }

    [Required(ErrorMessage ="Por Favor, Informe o texto")]
    [StringLength(500,ErrorMessage = "O texto deve possuir no máximo 500 caracteres")]
    public string Texto { get; set; }

    [Required(ErrorMessage = "Por favor, informe a nota")]
    [Column(TypeName = "decimal(1,0)")]
    public decimal Nota { get; set; }

    [Display(Name = "Data da Avaliação")]
    [DataType(DataType.Date)]
    public DateTime DataAvaliacao { get; set; }
}