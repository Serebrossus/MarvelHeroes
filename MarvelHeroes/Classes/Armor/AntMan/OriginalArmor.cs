using MarvelHeroes.Interfaces;
using Ninject;
using System;
using System.Linq;

namespace MaevelHeroes.Classes.Armor.AntMan
{
    public class OriginalArmor: IArmor 
    {
        private readonly string _armorName = "OriginalArmor";

        public string ArmorName { get => _armorName; }


        public IGadget Gadget
        {
            get
            {
                if (_gadget == null)
                {
                    _gadget = Program.AppKernel.Get<IGadget>("Rope");
                }
                return _gadget;
            }
        }

        [Inject]
        public IGadget Gadget { get; }

        [Inject]
        public IWeapon Weapon { get; }

        private IUltimateWeapon[] _ultimateWeapons;

        public IUltimateWeapon[] UltimateWeapons
        {
            get
            {
                if (_ultimateWeapons == null)
                {
                    _ultimateWeapons = Program.AppKernel.Get<IUltimateWeapon[]>((x)
                        =>
                    { return x.Name == "InfinityGauntlet"; });
                }
                return _ultimateWeapons;
            }
        }


        public void RemoveArmor()
        {
            Console.WriteLine($"RemoveArmor {ArmorName}");
        }

        public void SplitArmor()
        {
            Console.WriteLine($"SplitArmor {ArmorName}");
        }

        public void UseGadget()
        {
            Gadget.UseGadget();
        }

        public void UseWeapon()
        {
            Weapons.ToList().ForEach(x =>
            {
                x.Kill();
            });
        }
        public void UseWeapon(int wType)
        {
            switch (wType)
            {
                case (int)WeaponType.Shield:
                    Program.AppKernel.Get<IWeapon>("Shield");
                    break;
                default:
                    UseWeapon();
                    break;
            }
        }


        public void WearArmor()
        {
            Console.WriteLine($"WearArmor {ArmorName}");
        }

        public void UseUltimateWeapon()
        {
            var random = new Random();
            UltimateWeapons.ToList().ForEach(x =>
            {
                x.Attack(random.Next(1, 11));
            });
        }

        public void UseUltimateWeapon(int attackType)
        {
            UltimateWeapons.ToList().ForEach(x =>
            {
                x.Attack(attackType);
            });
        }
    }
}