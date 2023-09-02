using ChallengeApp;

User user1 = new User("Adam", "32435sdfsdfw");

var name = user1.Login;
var log = user1.Password;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
var gameName = User.GameName;
var pi = Math.PI;

Console.WriteLine(result);
