
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
        /// <summary>
        /// Create list of weapons available to hero
        /// </summary>
        /// <param name="appKernel"></param>
        /// <param name="names"></param>
        /// <returns></returns>
        public static IEnumerable<IWeapon> PrepareWeapons(this IKernel appKernel, string[] names)
        {
            var weapons = new List<IWeapon>();
            foreach (var name in names)
            {
                var weapon = appKernel.Get<IWeapon>(name);
                if (!weapons.Any(x => x == weapon))
                {
                    weapons.Add(weapon);
                }
            }
            return weapons;
        }
        /// <summary>
        /// Create list of avengers (Ultimate version).
        /// The creation of hero goes throught the connections
        /// of the armor, the gadgets and weapons available to this hero
        /// </summary>
        /// <param name="appKernel"></param>
        /// <param name="names"></param>
        /// <returns></returns>
        public static IEnumerable<IUltimateAvenger> PrepareUltimateAvengers(this IKernel appKernel, string[] names)
        {
            var avengers = new List<IUltimateAvenger>();
            foreach (var name in names)
            {
                var avenger = appKernel.Get<IUltimateAvenger>(b=> {
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