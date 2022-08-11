namespace Admin.Models
{
    public class Chatter
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string First_Date { get; set; }
        public string Last_Date { get; set; }
        public int Message_Count { get; set; }
        public Chatter(int id, string username, string first_date, string last_date)
        {
            Id = id;
            Username = username;
            First_Date = first_date;
            Last_Date = last_date;
        }
        public Chatter(string username, int message_count)
        {
            Username = username;
            Message_Count = message_count;
        }
    }
}
