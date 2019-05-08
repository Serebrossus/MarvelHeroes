
using System;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes.Weapons
{
    public class Repulsor: IWeapon, IRepulsor
    {
        public void Destruction() => Console.WriteLine("Repulsor is Destruction");

        public void Kill() => Console.WriteLine("Repulsor is Kill");

        public void Stunning() => Console.WriteLine("Repulsor is Stunning");

        public void Push() => Console.WriteLine("Repulsor is Push");

        public void BurnOut() => Console.WriteLine("Repulsor is BurnOut");
    }
}