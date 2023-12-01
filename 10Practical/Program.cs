using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User(),
                new User(),
                new User()
            };
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
