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

        public void UseArmor()
        {
            throw new NotImplementedException();
        }
    }
}
