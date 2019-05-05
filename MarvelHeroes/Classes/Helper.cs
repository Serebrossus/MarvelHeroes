
using MarvelHeroes.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Ninject;

namespace MarvelHeroes.Classes
{
    public enum WeaponType
    {
        Hummer = 1,
        Repulsor = 2,
        Shield = 3
    }

    public enum AtacType
    {
        QuickAttack = 1,
        Attack = 2,
        QuickKill = 3,
        Kill = 4,
        Push = 5,
        Thunder = 6,
        Lighting = 7,
        EarthQuake = 8,
        MultipleSalvo = 9,
        Stunning = 10,
        Destruction = 11,
        InfinityStone = 12,
    }


    public static class Helper
    {
        public static IEnumerable<IWeapon> PrepareWeapons(string[] names)
        {
            var weapons = new List<IWeapon>();
            foreach (var name in names)
            {
                var weapon = Program.AppKernel.Get<IWeapon>(name);
                if (!weapons.Any(x => x == weapon))
                {
                    weapons.Add(weapon);
                }
            }
            return weapons;
        }
        public static IEnumerable<IUltimateAvenger> PrepareUltimateAvengers(string[] names)
        {
            var avengers = new List<IUltimateAvenger>();
            foreach (var name in names)
            {
                var avenger = Program.AppKernel.Get<IUltimateAvenger>(b=> {
                    return b.Name.ToLower() == name.ToLower().Trim();
                });
                if (!avengers.Any(x => x == avenger))
                {
                    avengers.Add(avenger);
                }
            }
            return avengers;
        }
    }
}