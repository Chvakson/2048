using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public static class ResultStorage
    {
        private static string fileName = "results.json";

        public static List<User> Get()
        {
            if (!File.Exists(fileName))
            {
                return new List<User>();
            }
            var jsonData = FileSystem.Get(fileName);
            return JsonConvert.DeserializeObject<List<User>>(jsonData);
        }

        public static void Append(User newUser)
        {
            var users = Get();
            users.Add(newUser);
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileSystem.Save(fileName, jsonData);
        }
    }
}