using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes
{
    public class Shuriken : IWeapon
    {
        public void Destruction()
        {
            Console.WriteLine("Shuriken is Destruction");
        }

        public void Kill()
        {
            Console.WriteLine("Shuriken is not Kill");
        }

        public void Stunning()
        {
            Console.WriteLine("Shuriken is Stunning");
        }
    }
}
