using System;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Weapons
{
    public class Hammer:IWeapon
    {
        public void Destruction()
        {
            Console.WriteLine("Hammer is Destruction");
        }

        public void Kill()
        {
            Console.WriteLine("Hammer is not Kill");
        }

        public void Stunning()
        {
            Console.WriteLine("Hammer is Stunning");
        }
    }
}
