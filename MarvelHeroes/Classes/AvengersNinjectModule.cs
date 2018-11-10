using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes.Classes
{
    public class AvengersNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Shield>().Named("Shield");
            Bind<IWeapon>().To<Repulsor>().Named("Repulsor");
            Bind<IWeapon>().To<Shuriken>().WhenInjectedInto<AntMan>();
        }
    }
}
