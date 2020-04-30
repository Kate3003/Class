using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Class
{ 
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Debug("Debug");

            List<Animal> pet = new List<Animal>();
            pet.Add(new Animal() { Name = "Мурка", age = 5 });
            pet.Add(new Animal() { Name = "Шарик", age = 7 });
            var sortedpet = from p in pet
                            orderby p.Name
                            select p;

            foreach (Animal p in sortedpet)
                Console.WriteLine(p.Name);
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Возраст животного " + age + " лет");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }

            Animal dog = new Dog();
            dog.voice();
            Cat cat = new Cat();
            cat.swim();
            Console.ReadKey();
        }
    }
}
