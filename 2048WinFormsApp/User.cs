namespace _2048WinFormsApp
{
    public class User
    {
        public string Name { get; set; }    
        public int ScoreValue { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
