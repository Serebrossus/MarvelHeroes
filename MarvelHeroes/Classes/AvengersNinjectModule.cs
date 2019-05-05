using MarvelHeroes.Classes.Armor;
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
            Bind<IWeapon>().To<Shield>().Named("Shield");
            Bind<IWeapon>().To<Repulsor>().Named("Repulsor");
            Bind<IWeapon>().To<Hammer>().Named("Hammer");
            Bind<IWeapon>().To<Shuriken>().WhenInjectedInto<AntMan>();

            Bind<IUltimateWeapon>().To<StormBreaker>().Named("StormBreaker");
            Bind<IUltimateWeapon>().To<InfinityGauntlet>().Named("InfinityGauntlet");

            Bind<IGadget>().To<NanoparticleGenerator>().Named("NanoparticleGenerator");
            Bind<IGadget>().To<Rope>().WhenInjectedInto<AntMan>();

            Bind<IArmor>().To<ClassicArmor>().Named("ThorClassicArmor");
            Bind<IArmor>().To<Mark_I>().Named("Mark_I");

            Bind<IUltimateAvenger>().To<Thor>().Named("Thor");
            Bind<IUltimateAvenger>().To<IronMan>().Named("IronMan");
        }
    }
}
