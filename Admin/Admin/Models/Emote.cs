namespace Admin.Models
{
    public class Emote
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Emote_Id { get; set; }
        public int Count { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string Date_Added { get; set; }
        public int Source { get; set; }
        public bool Active { get; set; }

        public Emote(string code, int count, string path)
        {
            Code = code;
            Count = count;
            Path = path;
        }
        public Emote(string code, int count, string url, string path, string date_added, int source, bool active)
        {
            Code = code;
            Count = count;
            Url = url;
            Path = path;
            Date_Added = date_added;
            Source = source;
            Active = active;
        }
        public Emote(int id, string code, string emote_id, int count, string url, string path, string date_added, int source, bool active)
        {
            Id = id;
            Code = code;
            Emote_Id = emote_id;
            Count = count;
            Url = url;
            Path = path;
            Date_Added = date_added;
            Source = source;
            Active = active;
        }
    }
}
