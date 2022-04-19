using System;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            AnimalHandler handler = new AnimalHandler(cat);
            handler.Sound();

           
            AnimalHandler handler1= new AnimalHandler(new Dog());
            handler1.Sound();
        }
    }
}

