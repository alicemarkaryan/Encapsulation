using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erexeqihamar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("male", "Ani", -55);
            client1.setAge(-55);
            client1.setGender("male");
            Console.WriteLine(client1.getName("Ani"));
        }
    }
}
