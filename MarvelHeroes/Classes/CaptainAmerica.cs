using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class CaptainAmerica : IAvenger
    {
        readonly IWeapon _weapon;

        public CaptainAmerica([Named("Shield")]IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void UseWeapon()
        {
            _weapon.Kill();
        }

        public void UseGadget()
        {
            throw new NotImplementedException();
        }
    }
}
