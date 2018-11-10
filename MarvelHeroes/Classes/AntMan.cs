using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class AntMan : IAvenger
    {
        [Inject]
        public IWeapon Weapon { get; set; }

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
