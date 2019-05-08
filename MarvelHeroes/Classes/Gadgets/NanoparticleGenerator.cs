using System;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Gadgets
{
    public class NanoparticleGenerator:IGadget
    {
        public void UseGadget()
        {
            Console.WriteLine("Use nanoparticle generator");
        }
    }
}