using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erexeqihamar
{
    internal class Client
    {
       private string Name { get; set; }
        private int Age { get; set; }
       private string Gender { get; set; }

      public Client(string gender, string name, int age)
        {
            this.Age=getAge();
            this.Name = name;
           this.Gender= getGender();       
        }

        public int getAge()
        {
            return Age; 
        }
        public void setAge(int age) 
        {
            if (age > 21 && age < 80)
            {
                Console.WriteLine(age);

            }
            else
            {
                Console.WriteLine("Age doesn't exist");
            }
        }
        public string getGender()
        {
            return Gender;
        }
        public void setGender(string gender) {

            if (gender.Equals("male"))
            {
                Console.WriteLine(gender);
            }
            else
            {
                Console.WriteLine("Gender doesn't exist");
            }
        }

        public string getName(string name)
        {
            return name;
        }




    }
}
