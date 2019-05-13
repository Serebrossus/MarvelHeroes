using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class AvengersAssembly
    {
        /// <summary>
        /// Creation of Avenger and demonstration is his capabilities
        /// </summary>
        /// <param name="appKernel"></param>
        /// <param name="avengerName"></param>
        /// <returns></returns>
        public bool Assembly (IKernel appKernel,string avengerName) {
            try {
                var names = avengerName.Split(',').ToArray();
                var avengers = appKernel.PrepareUltimateAvengers(names);

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
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}