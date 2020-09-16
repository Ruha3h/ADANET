using ADANET_FRAMEWORK.Models;
using ADANET_FRAMEWORK.Repos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADANET_FRAMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            var repo = new UserRepo(connectionString);

            repo.DeleteAll();

            var id = repo.Create(new User
            {
                Name = "Nikolay",
                Age = 24
            });

            Console.WriteLine(repo.Read(id));

            id = repo.Create(new User
            {
                Name = "asdasd",
                Age = 25
            });

            Console.WriteLine(repo.Read(id));
            id = repo.Create(new User
            {
                Name = "fghfgh",
                Age = 25
            });

            Console.WriteLine(repo.Read(id));
            id = repo.Create(new User
            {
                Name = "werwer",
                Age = 25
            });

            Console.WriteLine(repo.Read(id));
            id = repo.Create(new User
            {
                Name = "cvbcvbcbv",
                Age = 25
            });

            Console.WriteLine(repo.Read(id));

            Console.WriteLine("Press Any Key...");
            Console.ReadKey();

            repo.DeleteByMass(new int[]{1,3,5 });

        }
    }
}
