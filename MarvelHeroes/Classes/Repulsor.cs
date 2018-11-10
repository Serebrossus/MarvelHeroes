using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes
{
    public class Repulsor : IWeapon
    {
        public void Destruction()
        {
            Console.WriteLine("Repulsor is Destruction");
        }

        public void Kill()
        {
            Console.WriteLine("Repulsor is Kill");
        }

        public void Stunning()
        {
            Console.WriteLine("Repulsor is Stunning");
        }
    }
}
