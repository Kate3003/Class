using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Animal
    {
        [My(color = "red", breed = "dachshund")]
       
        public int age;
        public string Name;
        public void voice()
        {
            Console.WriteLine("Голос!");
        }
    }
}
