using System.ComponentModel.DataAnnotations;

namespace ePizza.UI.Models.ProductTypes
{
    public class ProductTypeUpdateViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim alanı boş olamaz")]
        public string Name { get; set; }
    }
}
