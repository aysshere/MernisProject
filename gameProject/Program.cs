using GameProject;

namespace gameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2002, FirstName = "ayse", LastName = "surer", IdentityNumber = 12345 });
                
        }
    }
}
