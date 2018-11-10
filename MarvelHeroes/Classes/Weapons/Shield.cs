using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Weapons
{
    public class Shield : IWeapon
    {
        public void Destruction()
        {
            Console.WriteLine("Shield is not Destruction");
        }

        public void Kill()
        {
            Console.WriteLine("Shield is not Kill");
        }

        public void Stunning()
        {
            Console.WriteLine("Shield is stunning");
        }
    }
}
