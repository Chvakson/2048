using System.IO;
using System.Text;

namespace _2048WinFormsApp
{
    public static class FileSystem
    {
        public static string Get(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.UTF8);
            var data = reader.ReadToEnd();
            reader.Close();
            return data;
        }

        public static void Save(string fileName, string data)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }
    }
}
