using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class IronMan : IAvenger
    {
        //TODO Если реализовать свойство через Inject и обычным способом в одном классе, то свойство с Inject будет равно null. Причину не выяснял!
        private IGadget _gadget;

        public IGadget Gadget
        {
            get
            {
                if (_gadget == null)
                {
                    _gadget = Program.AppKernel.Get<IGadget>("NanoparticleGenerator");
                }
                return _gadget;
            }
        }

        private IWeapon[] _weapon;

        public IWeapon[] Weapon
        {
            get
            {
                if (_weapon == null)
                {
                    _weapon = Program.AppKernel.Get<IWeapon[]>((x) => { return x.Name == "Repulsor" || x.Name == "Hammer" || x.Name == "Shield"; });
                    //("Repulsor");
                }
                return _weapon;
            }
        }

        public void UseWeapon()
        {
            Weapon.ToList().ForEach(x =>
            {
                x.Kill();
            });
            //Weapon.Kill();
        }
        public void UseWeapon(int wType)
        {
            switch (wType)
            {
                case (int)WeaponType.Hummer:
                    Program.AppKernel.Get<IWeapon>("Hummer");
                    break;
                case (int)WeaponType.Shield:
                    Program.AppKernel.Get<IWeapon>("Shield");
                    break;
                case (int)WeaponType.Repulsor:
                    Program.AppKernel.Get<IWeapon>("Repulsor");
                    break;
                default:
                    UseWeapon();
                    break;
            }
        }

        public void UseGadget()
        {
            Gadget.UseGadget();
        }
    }
}
