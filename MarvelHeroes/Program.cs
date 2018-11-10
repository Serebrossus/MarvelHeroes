using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using MarvelHeroes.Classes;

namespace MarvelHeroes
{
    class Program
    {
        public static IKernel AppKernel;

        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new AvengersNinjectModule());
            var cap = AppKernel.Get<CaptainAmerica>();
            cap.UseWeapon();

            var ironman = new IronMan();
            ironman.UseWeapon();

            var antman = AppKernel.Get<AntMan>();
            antman.UseWeapon();

            Console.ReadLine();
        }
    }
}
