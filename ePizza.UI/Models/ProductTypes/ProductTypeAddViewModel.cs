using System.ComponentModel.DataAnnotations;

namespace ePizza.UI.Models.ProductTypes
{
    public class ProductTypeAddViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "İsim alanı boş olamaz")]
        public string Name { get; set; }
    }
}
