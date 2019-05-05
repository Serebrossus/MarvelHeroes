using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelHeroes.Interfaces
{
    interface IArmor
    {
        string ArmorName { get; }

        [Inject]
        IGadget Gadget { get; }

        [Inject]
        IWeapon[] Weapons { get; }

        [Inject]
        IUltimateWeapon[] UltimateWeapons { get; }

        void UseWeapon();
        void UseWeapon(int wType);
        void UseUltimateWeapon();
        void UseUltimateWeapon(int attackType);
        void UseGadget();
        void WearArmor();
        void RemoveArmor();
        void SplitArmor();
    }
}
