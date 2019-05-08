using MarvelHeroes.Interfaces;
using Ninject;
using System;
using System.Linq;

namespace MarvelHeroes.Classes.Armor.AntMan
{
    public class AntMan_I: IArmor
    {
        //TODO - Need work
        public AntMan_I() {
            if(_weapons != null)
                _weapons.Append(Weapon);
        }
        private readonly string _armorName = "AntMan Armor";

        public string ArmorName { get => _armorName; }


        [Inject]
        public IGadget Gadget { get; }
        private IWeapon[] _weapons;

        public IWeapon[] Weapons
        {
            get
            {
                return _weapons;
            }
        }
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
            if(Gadget==null) return;
            Gadget.UseGadget();
        }

        public void UseWeapon()
        {
            if(Weapons == null) return;
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