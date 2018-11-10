using MarvelHeroes.Classes.Gadgets;
using MarvelHeroes.Classes.Weapons;
using MarvelHeroes.Interfaces;
using Ninject.Modules;

namespace MarvelHeroes.Classes
{
    public class AvengersNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Shield>().Named("Shield");
            Bind<IWeapon>().To<Repulsor>().Named("Repulsor");
            Bind<IWeapon>().To<Hammer>().Named("Hammer");
            Bind<IWeapon>().To<Shuriken>().WhenInjectedInto<AntMan>();

            Bind<IGadget>().To<NanoparticleGenerator>().Named("NanoparticleGenerator");
            Bind<IGadget>().To<Rope>().WhenInjectedInto<AntMan>();
        }
    }
}
