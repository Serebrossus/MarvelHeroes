using MarvelHeroes.Classes.Armor.IronMan;
using MarvelHeroes.Classes.Armor.AntMan;
using MarvelHeroes.Classes.Armor.Thor;
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
            Bind<IWeapon>().To<Repulsor>().Named("Repulsor");
            Bind<IWeapon>().To<Hammer>().Named("Hammer");
            Bind<IWeapon>().To<Shield>().Named("Shield");
            // TODO - understand why binding doesn't work. Old version "...WhenInjectedInto<AntMan>()" doesn't work either
            Bind<IWeapon>().To<Shuriken>().WhenInjectedInto<AntMan_I>();

            Bind<IUltimateWeapon>().To<InfinityGauntlet>().Named("InfinityGauntlet");
            Bind<IUltimateWeapon>().To<StormBreaker>().Named("StormBreaker");

            Bind<IGadget>().To<NanoparticleGenerator>().Named("NanoparticleGenerator");
            Bind<IGadget>().To<Rope>().WhenInjectedInto<AntMan>();

            Bind<IArmor>().To<Mark_I>().Named("Mark_I");
            Bind<IArmor>().To<AntMan_I>().Named("AntMan_I");
            Bind<IArmor>().To<Thor_I>().Named("ThorClassicArmor");

            Bind<IUltimateAvenger>().To<IronMan>().Named("IronMan");
            Bind<IUltimateAvenger>().To<AntMan>().Named("AntMan");
            Bind<IUltimateAvenger>().To<Thor>().Named("Thor");
        }
    }
}
