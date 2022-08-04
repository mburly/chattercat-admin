namespace Admin.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Start_Datetime { get; set; }
        public string End_Datetime { get; set; }

        public Session(int id, string title, string start_Datetime, string end_Datetime)
        {
            Id = id;
            Title = title;
            Start_Datetime = start_Datetime;
            End_Datetime = end_Datetime;
        }

        public Session(string title, string start_Datetime)
        {
            Title = title;
            Start_Datetime = start_Datetime;
        }
    }
}
