using System;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Gadgets
{
    public class Rope: IGadget
    {
        public void UseGadget()
        {
            Console.WriteLine("Use Rope");
        }
    }
}