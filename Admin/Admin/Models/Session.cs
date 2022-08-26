namespace Admin.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Start_Datetime { get; set; }
        public string End_Datetime { get; set; }
        public string Length { get; set; }

        public Session(int id, string title, string start_datetime, string end_datetime, string length)
        {
            Id = id;
            Title = title;
            Start_Datetime = start_datetime;
            End_Datetime = end_datetime;
            Length = length;
        }
        public Session(int id, string title, string end_datetime, string length)
        {
            Id = id;
            Title = title;
            End_Datetime = end_datetime;
            Length = length;
        }
    }
}
