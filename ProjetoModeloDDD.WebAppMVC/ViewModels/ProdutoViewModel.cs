using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.WebAppMVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Campo {0} deve ser informado")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} deve ser informado")]

        [DataType(DataType.Currency)]
        [RangeAttribute(typeof(decimal), "1.0", "9999999999.99", ErrorMessage = "{0} dever ter entre {1} e {2}!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }
        
        public int ClienteId { get; set; }
        
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
