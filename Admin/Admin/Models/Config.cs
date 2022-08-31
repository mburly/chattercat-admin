namespace Admin.Models
{
    public class Config
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public string Token { get; set; }
        public string Secret_Key { get; set; }
        
        public Config()
        {
            using (StreamReader sr = new StreamReader(FileRoot.Config))
            {
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					if (line == String.Empty || line == "[db]" || line == "[twitch]")
					{
						continue;
					}
					else
					{
						if (line.Contains("host ="))
						{
							Host = line.Split("= ")[1];
						}
						else if (line.Contains("user ="))
						{
							User = line.Split("= ")[1];
						}
						else if (line.Contains("password ="))
						{
							Password = line.Split("= ")[1];
						}
						else if (line.Contains("nickname ="))
						{
							Nickname = line.Split("= ")[1];
						}
						else if (line.Contains("token ="))
						{
							Token = line.Split("= ")[1];
						}
						else if (line.Contains("secret_key ="))
						{
							Secret_Key = line.Split("= ")[1];
						}
					}
				}
			}
        }
    }
}
