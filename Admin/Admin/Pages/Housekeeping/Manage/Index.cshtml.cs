using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Housekeeping
{
    [AllowAnonymous]
    public class ManageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
