using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class AnimalHandlerWithConstructor
    {
        private readonly IAnimal animal;

        public AnimalHandlerWithConstructor(IAnimal animal)
        {
            this.animal = animal;
        }

        public void Sound()
        {
            animal.MakingSound();
        }

    }
}
