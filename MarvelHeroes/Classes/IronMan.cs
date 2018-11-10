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

        private IWeapon _weapon;
        
        public IWeapon Weapon
        {
            get
            {
                if (_weapon == null)
                {
                    _weapon = Program.AppKernel.Get<IWeapon>("Repulsor");
                }
                return _weapon;
            }
        }

        public void UseWeapon()
        {
            Weapon.Kill();
        }

        public void UseGadget()
        {
            Gadget.UseGadget();
        }
    }
}
