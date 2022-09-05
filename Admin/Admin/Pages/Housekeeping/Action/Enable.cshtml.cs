using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace Admin.Pages.Housekeeping.Action
{
	[AllowAnonymous]
    public class EnableModel : PageModel
    {
        public void OnGet()
        {
			string channel = String.Empty;
			string emote_id = String.Empty;
			try
			{
				string[] param = RouteData.Values["HousekeepingTemplate"].ToString().Split('$');
				channel = param[0];
				emote_id = param[1];
			}
			catch
			{
				Response.Redirect("/Housekeeping");
			}
			try
			{
				MySqlConnection conn = new MySqlConnection($"server={Constants.Config.Host};port=3306;database=cc_{channel};uid={Constants.Config.User};password={Constants.Config.Password};");
				conn.Open();
				string sql = $"UPDATE emotes SET active = 1 WHERE emote_id = \"{emote_id}\"";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
                sql = $"UPDATE logs SET user_id = \"{User.Identity.Name}\" WHERE id = (SELECT id FROM logs ORDER BY id DESC LIMIT 1)";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect($"/Housekeeping/Manage/Emotes/{channel}");
			}
			catch
			{
				Response.Redirect($"/Housekeeping/Manage/Emotes/{channel}");
			}
		}
    }
}
