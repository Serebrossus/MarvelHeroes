using System;
using System.Linq;
using Ninject;
using MarvelHeroes.Classes;
using MarvelHeroes.Interfaces;
using Ninject.Planning.Bindings;
using Ninject.Syntax;
using System.Collections.Generic;

namespace MarvelHeroes
{
    class Program
    {
        public static IKernel AppKernel;


        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new AvengersNinjectModule());
            try
            {
                //Func<IBindingMetadata, bool> constraint = (x) =>
                //{
                //    Console.WriteLine($"Weapon Name {x.Name}");
                //    return x.Name == "Hammer";
                //};
                //var weapons = AppKernel.Get<IWeapon[]>("Hammer");

                //var abc = AppKernel.Get<IWeapon>((b) => 
                //{
                //    Console.WriteLine(b.Name);
                //    return b.Name == "Hammer" || b.Name == "Repulsor";
                //});

                //weapons.ToList().ForEach(x => Console.WriteLine(x));

                //Console.WriteLine(abc);

                //Console.WriteLine("Create Avenger CaptainAmerica");
                //var cap = AppKernel.Get<CaptainAmerica>();
                //cap.UseWeapon();

                //Console.WriteLine("Create Avenger IronMan");
                //var ironman = new IronMan();
                //ironman.UseWeapon();
                //ironman.UseGadget();

                //Console.WriteLine("Create Avenger AntMan");
                //var antman = AppKernel.Get<AntMan>();
                //antman.UseWeapon();
                //antman.UseGadget();

                var thor = AppKernel.Get<IUltimateAvenger>("Thor");
                thor.GetArmorName();
                thor.RemoveArmor();

                Console.WriteLine("Enter avenger name or names separates by commas");
                var avengerName = Console.ReadLine();
                var names = avengerName.Split(',').ToArray();
                var avengers = Helper.PrepareUltimateAvengers(names);

                avengers.ToList().ForEach(avenger =>
                {
                    avenger.GetArmorName();
                    avenger.WearArmor();
                    avenger.UseGadget();
                    avenger.UseWeapon();
                    avenger.UseUltimateWeapon();
                    avenger.UseUltimateWeapon((int)AtacType.Thunder);
                    avenger.UseUltimateWeapon((int)AtacType.EarthQuake);
                    avenger.UseUltimateWeapon((int)AtacType.Lighting);
                    avenger.SplitArmor();
                    avenger.RemoveArmor();
                    Console.WriteLine("//--------------------------//");
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
