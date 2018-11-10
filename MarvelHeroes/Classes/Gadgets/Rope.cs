using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Gadgets
{
    public class Rope:IGadget
    {
        public void UseGadget()
        {
            Console.WriteLine("Use Rope");
        }
    }
}
