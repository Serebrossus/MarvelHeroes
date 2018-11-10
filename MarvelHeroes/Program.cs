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
            try
            {
                Console.WriteLine("Create Avenger CaptainAmerica");
                var cap = AppKernel.Get<CaptainAmerica>();
                cap.UseWeapon();

                Console.WriteLine("Create Avenger IronMan");
                var ironman = new IronMan();
                ironman.UseWeapon();
                ironman.UseGadget();

                Console.WriteLine("Create Avenger AntMan");
                var antman = AppKernel.Get<AntMan>();
                antman.UseWeapon();
                antman.UseGadget();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
