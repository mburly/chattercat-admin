using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Housekeeping.Manage
{
    [AllowAnonymous]
    public class UsersModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
