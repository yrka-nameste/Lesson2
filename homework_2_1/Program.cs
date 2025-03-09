using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { name = "Alex", age = 18 },
                new User { name = "Bob", age = 25 },
                new User()
            };
            var validator = new UserValidator();
            var procceor = new UserProcessor();
            var repositpry= new UserRepository();

            foreach (var user in users)
            {

                try
                {
                    validator.Validate(user);
                    procceor.Proccess(user);
                    repositpry.Save(user);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
