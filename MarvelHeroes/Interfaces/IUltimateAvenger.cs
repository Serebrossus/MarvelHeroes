using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelHeroes.Interfaces
{
    public interface IUltimateAvenger
    {
        void UseWeapon();
        void UseWeapon(int wType);
        void UseUltimateWeapon();
        void UseUltimateWeapon(int wType);
        void UseGadget();
        void WearArmor();
        void RemoveArmor();
        void SplitArmor();
        string GetArmorName();
    }
}