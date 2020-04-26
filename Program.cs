using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Class
{
    public class Animal
    {
        public int age;
        public string Name;
        public void voice()
        {
            Console.WriteLine("Голос!");
        }
    }
    public interface Swimmable
    {
       void swim();
    }
    class Cat : Swimmable
    {
        public void swim()
        {
            Console.WriteLine("Кошка плывет!");
        }
    }
    public class Dog : Animal
    {
        public void voice()
        {
            Console.WriteLine("Гав-гав!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> pet = new List<Animal>();
            pet.Add(new Animal() { Name = "Мурка", age = 5});
            pet.Add(new Animal() { Name = "Шарик", age = 7});
            var sortedpet = from p in pet
                              orderby p.Name
                              select p;

            foreach (Animal p in sortedpet)
                Console.WriteLine(p.Name);
            Animal dog = new Dog();
            dog.voice();
            Cat cat = new Cat();
            cat.swim();
            Console.ReadKey();
        }
    }
}
