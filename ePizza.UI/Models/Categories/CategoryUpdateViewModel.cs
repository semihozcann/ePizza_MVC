using System.ComponentModel.DataAnnotations;

namespace ePizza.UI.Models.Categories
{
    public class CategoryUpdateViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim kısmı boş olamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama kısmı boş olmaz")]
        public string Description { get; set; }
    }
}
