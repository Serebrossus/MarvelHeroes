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
    // TODO add xUnit test https://docs.microsoft.com/ru-ru/dotnet/core/testing/unit-testing-with-dotnet-test
    // TODO or add nUnit test https://docs.microsoft.com/ru-ru/dotnet/core/testing/unit-testing-with-nunit
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new AvengersNinjectModule());
            
            Console.WriteLine("Enter avenger name or names separates by commas");
            var avengerName = Console.ReadLine();

            var assembly = new AvengersAssembly();
            assembly.Assembly(AppKernel, avengerName);

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
