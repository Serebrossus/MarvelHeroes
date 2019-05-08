using MarvelHeroes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelHeroes.Classes.Weapons
{
    public class StormBreaker : IUltimateWeapon
    {
        public void Attack(int attackType)
        {
            switch (attackType)
            {
                case (int)AtacType.Attack:
                    Console.WriteLine("Attack");
                    break;
                case (int)AtacType.Destruction:
                    Console.WriteLine("Destruction");
                    break;
                case (int)AtacType.EarthQuake:
                    Console.WriteLine("EarthQuake");
                    break;
                case (int)AtacType.Kill:
                    Console.WriteLine("Kill");
                    break;
                case (int)AtacType.Lighting:
                    Console.WriteLine("Lighting");
                    break;
                case (int)AtacType.MultipleSalvo:
                    Console.WriteLine("MultipleSalvo");
                    break;
                case (int)AtacType.Push:
                    Console.WriteLine("Push");
                    break;
                case (int)AtacType.QuickKill:
                    Console.WriteLine("QuickKill");
                    break;
                case (int)AtacType.Stunning:
                    Console.WriteLine("Stunning");
                    break;
                case (int)AtacType.Thunder:
                    Console.WriteLine("Thunder");
                    break;
                default:
                    Console.WriteLine("QuickAttack");
                    break;
            }
        }
    }
}
