using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages
{
    [AllowAnonymous]
    public class HousekeepingModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
