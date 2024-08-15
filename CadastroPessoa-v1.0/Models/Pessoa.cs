using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoa_v1._0.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("id")]
        public int id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome:")]
        public string nome { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone:")]
        public string telefone { get; set; }

        [Column("bairro")]
        [Display(Name = "Bairro:")]
        public string bairro { get; set; }

        [Column("cidade")]
        [Display(Name = "Cidade:")]
        public string cidade { get; set; }

        [Column("estado")]
        [Display(Name = "Estado:")]
        public string estado { get; set; }
    }
}
