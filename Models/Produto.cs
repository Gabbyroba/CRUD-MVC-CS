using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVCSQL.Models
{
    [Table("ControledeProdutos")]


    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }


        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        public string? Quantidade { get; set; }


        [Column("Preço")]
        [Display(Name = "Preço")]
        public string? Preço { get; set; }
    }
}
