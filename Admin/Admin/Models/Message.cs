namespace Admin.Models
{
	public class Message
	{
		public string Username { get; set; }
		public string Text { get; set; }
		public string Datetime { get; set; }

		public Message(string username, string text, string datetime)
		{
			Username = username;
			Text = text;
			Datetime = datetime;
		}
	}
}
