using System;
using System.Linq;
using System.Collections.Generic;
using Ninject;
using Ninject.Planning.Bindings;
using Ninject.Syntax;
using MarvelHeroes.Classes;
using MarvelHeroes.Interfaces;

namespace MarvelHeroes
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new AvengersNinjectModule());
            try {
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
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
