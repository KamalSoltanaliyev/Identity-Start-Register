using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Areas.Admin.ViewModels
{
    public class SliderCreateViewModel
    {
        public int Id { get; set; }
        public string? Offer { get; set; }
        [Required(ErrorMessage = "Bow qoyma burani")]
        public string Title { get; set; }
        public string? Description { get; set; }
        public IFormFile Image { get; set; }

    }
}
