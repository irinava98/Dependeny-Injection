﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Cat: IAnimal
    {
        public void MakingSound()
        {
            Console.WriteLine("Meoww");
        }
    }
}