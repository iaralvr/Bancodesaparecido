using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoApi.Models
{
    [Table("Observacao")]
    public class Observacoes
    {
        [Column("ObservacaoId")]
        [Display(Name = "Código da Observacao")]
        public int Id { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Descricao")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Local")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Data Observacao")]
        public DateTime ObservacaoData { get; set; }


        [ForeignKey("PessoaId")]
        [Display(Name = "Código da Pessoa")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }


        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }



    }
}
