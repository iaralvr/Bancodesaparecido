using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoApi.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("PessoaId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome da Pessoa")]
        public string PessoaNome { get; set; } = string.Empty;

        [Column("PessoaRoupa")]
        [Display(Name = "Roupa da Pessoa")]
        public string PessoaRoupa { get; set; } = string.Empty;

        [Column("PessoaCor")]
        [Display(Name = "Cor da Pessoa")]
        public string PessoaCor { get; set; } = string.Empty;

        [Column("PessoaSexo")]
        [Display(Name = "Sexo da Pessoa")]
        public string PessoaSexo { get; set; } = string.Empty;

        [Column("PessoaObservacao")]
        [Display(Name = "Observacão da Pessoa")]
        public string PessoaObservacao { get; set; } = string.Empty;

        [Column("PessoaLocalDesaparecimento")]
        [Display(Name = "Local de Desaparecimento da Pessoa")]
        public string PessoaLocalDesaparecimento { get; set; } = string.Empty;

        [Column("PessoaFoto")]
        [Display(Name = "Foto da Pessoa")]
        public string PessoaFoto { get; set; } = string.Empty;

        [Column("PessoaDtDesaparecimento")]
        [Display(Name = "Data de Desaparecimento")]
        public DateTime PessoaDtDesaparecimento { get; set; }

        [Column("PessoaDtEncontro")]
        [Display(Name = "Data de Encontro")]
        public DateTime? PessoaDtEncontro { get; set; }

        [Column("PessoaStatus")]
        [Display(Name = "Status da Pessoa")]
        public Byte PessoaStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Código do Usuário")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

    }

}

