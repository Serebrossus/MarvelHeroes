using MarvelHeroes.Interfaces;
using Ninject;
using System;
using System.Linq;

namespace MarvelHeroes.Classes.Armor.Thor
{
    class ClassicArmor : IArmor
    {

        private string _armorName = "Thor Classic Armor";

        public string ArmorName { get => _armorName; }

        private IGadget _gadget;

        public IGadget Gadget
        {
            get
            {
                if (_gadget == null)
                {
                    _gadget = Program.AppKernel.Get<IGadget>("NanoparticleGenerator");
                }
                return _gadget;
            }
        }

        private IWeapon[] _weapons;

        public IWeapon[] Weapons
        {
            get
            {
                if (_weapons == null)
                {
                    var names = new string[] { "Hammer", "Shield" };
                    _weapons = Helper.PrepareWeapons(names).ToArray();
                }
                return _weapons;
            }
        }

        private IUltimateWeapon[] _ultimateWeapons;

        public IUltimateWeapon[] UltimateWeapons
        {
            get
            {
                if (_ultimateWeapons == null)
                {
                    _ultimateWeapons = Program.AppKernel.Get<IUltimateWeapon[]>((x)
                        => { return x.Name == "StormBreaker"; });
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
            Console.WriteLine($"Weapon count {Weapons.Count()}");
            Weapons.ToList().ForEach(x =>
            {
                x.Kill();
            });
        }

        public void UseWeapon(int wType)
        {
            switch (wType)
            {
                case (int)WeaponType.Hummer:
                    Program.AppKernel.Get<IWeapon>("Hummer");
                    break;
                case (int)WeaponType.Shield:
                    Program.AppKernel.Get<IWeapon>("Shield");
                    break;
                case (int)WeaponType.Repulsor:
                    Program.AppKernel.Get<IWeapon>("Repulsor");
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
                x.Attack(random.Next(1,11));
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
