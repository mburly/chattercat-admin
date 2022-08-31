using Admin.Models;
namespace Admin
{
    public class FileRoot
    {
        public static string Root => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        public static string Config => $"{Root}{Path.DirectorySeparatorChar}conf.ini";
        public static string Streams => $"{Root}{Path.DirectorySeparatorChar}streams.txt";
    }
}
