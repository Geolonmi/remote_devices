using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Regis.Web
{
    /// <summary>
    /// Modèle associé à la page d'index.
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public IndexModel()
        {
        }

        /// <summary>
        /// Yolo.
        /// </summary>
        /// <returns>Result.</returns>
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}