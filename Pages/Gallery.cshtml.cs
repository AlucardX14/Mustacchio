using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mustacchio.Pages
{
    public class GalleryModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
