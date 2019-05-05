using MarvelHeroes.Interfaces;
using Ninject;

namespace MarvelHeroes.Classes
{
    public class Thor: IUltimateAvenger
    {
        private IArmor _armor;

        private IArmor Armor
        {
            get
            {
                if (_armor == null)
                {
                    _armor = Program.AppKernel.Get<IArmor>("ThorClassicArmor");
                }
                return _armor;
            }
        }

        public void UseWeapon() => Armor.UseWeapon();

        public void UseWeapon(int wType) => Armor.UseWeapon(wType);

        public void UseUltimateWeapon() => Armor.UseUltimateWeapon();

        public void UseUltimateWeapon(int wType) => Armor.UseUltimateWeapon(wType);

        public void UseGadget() => Armor.UseGadget();

        public void WearArmor() => Armor.WearArmor();

        public void RemoveArmor() => Armor.RemoveArmor();

        public void SplitArmor() => Armor.SplitArmor();

        public string GetArmorName() => Armor.ArmorName;
    }
}
