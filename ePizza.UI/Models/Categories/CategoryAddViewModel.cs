using System.ComponentModel.DataAnnotations;

namespace ePizza.UI.Models.Categories
{
    public class CategoryAddViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "İsim kısmı boş olamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama kısmı boş olmaz")]
        public string Description { get; set; }
    }
}
