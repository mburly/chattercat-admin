using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Housekeeping.View
{
    [AllowAnonymous]
    public class MessagesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
