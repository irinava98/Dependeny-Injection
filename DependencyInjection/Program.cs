using System;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            AnimalHandlerWithConstructor handler = new AnimalHandlerWithConstructor(cat);
            handler.Sound();


            AnimalHandlerWithConstructor handler1 = new AnimalHandlerWithConstructor(new Dog());
            handler1.Sound();

            AnimalHandlerWithProperty handler2 = new AnimalHandlerWithProperty();
            handler2.Animal = new Cow();
            handler2.Sound();

            AnimalHandlerWithMethod handler3 = new AnimalHandlerWithMethod();
            handler3.Sound(new Fish());
        }
    }
}

