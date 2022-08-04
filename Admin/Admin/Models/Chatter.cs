namespace Admin.Models
{
    public class Chatter
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string First_Date { get; set; }
        public string Last_Date { get; set; }
        public int Message_Count { get; set; }

        public Chatter(int id, string username, string first_Date, string last_Date)
        {
            Id = id;
            Username = username;
            First_Date = first_Date;
            Last_Date = last_Date;
        }

        public Chatter(string username, int message_count)
        {
            Username = username;
            Message_Count = message_count;
        }
    }
}
