using System;
using System.Linq;
using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes.Armor.Thor
{
    public class Thor_I: IArmor
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
            if(Gadget == null)
                return;
            
            Gadget.UseGadget();
        }

        public void UseWeapon()
        {
            if(Weapons == null)
                return;

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