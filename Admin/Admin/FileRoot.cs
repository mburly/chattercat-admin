namespace Admin
{
    public class FileRoot
    {
        public static string Root => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        public static string Streams => $"{Root}{Path.DirectorySeparatorChar}streams.txt";
    }
}
