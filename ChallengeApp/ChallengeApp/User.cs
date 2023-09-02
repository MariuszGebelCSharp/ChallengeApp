namespace ChallengeApp
{
    public class User
    {
        public static string GameName = "Diablo";
        private List<int> score = new List<int>();

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                var i = 1;
                foreach (var item in score)
                {
                    Console.WriteLine(i + " => " + item);
                    i++;
                }
                return this.score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
