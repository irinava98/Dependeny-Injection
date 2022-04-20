using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class AnimalHandlerWithMethod
    {
        public AnimalHandlerWithMethod()
        {

        }

        public void Sound(IAnimal animal)
        {
            animal.MakingSound();
        }
    }
}
