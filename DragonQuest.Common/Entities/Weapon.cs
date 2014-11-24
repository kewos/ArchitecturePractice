using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonQuestWFA.Common
{
    public abstract class Weapon : IWeapon
    {
        public virtual string Name { get; set; }
        //浮動傷害
        public int UnsteadyDamage { get; set; }
        private int _damage;
        public virtual int Damage
        {
            get
            {
                return _damage + new Random().Next(0, UnsteadyDamage);
            }
            set
            {
                _damage = value;
            }
        }
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            base.Name = "長劍";
            base.Damage = 15;
            base.UnsteadyDamage = 3;
        }
    }

    public class Axe : Weapon
    {
        public Axe()
        {
            base.Name = "斧頭";
            base.Damage = 10;
            base.UnsteadyDamage = 30;
        }
    }

    public class Bow : Weapon
    {
        public Bow()
        {
            base.Name = "長弓";
            base.Damage = 14;
            base.UnsteadyDamage = 10;
        }
    }

    public class Knife : Weapon
    {
        public Knife()
        {
            base.Name = "小刀";
            base.Damage = 17;
            base.UnsteadyDamage = 2;
        }
    }

    public class PlusWeaponSuffix : Weapon
    {
        public Weapon weapon;

        public PlusWeaponSuffix(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage{
            get
            {
                return weapon.Damage + 5;
            }
        }

        public override string Name
        {
            get
            {
                return "被強化的" + weapon.Name;
            }
        }
    }

    public class LegendWeaponSuffix : Weapon
    {
        public Weapon weapon;

        public LegendWeaponSuffix(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage
        {
            get
            {
                return weapon.Damage + 50;
            }
        }

        public override string Name
        {
            get
            {
                return "傳說的" + weapon.Name;
            }
        }
    }

    public class SilverWeaponSuffix : Weapon
    {
        public Weapon weapon;

        public SilverWeaponSuffix(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage
        {
            get
            {
                return weapon.Damage + 15;
            }
        }

        public override string Name
        {
            get
            {
                return "銀的" + weapon.Name;
            }
        }
    }

    public class GoldWeaponSuffix : Weapon
    {
        public Weapon weapon;

        public GoldWeaponSuffix(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage
        {
            get
            {
                return weapon.Damage + 20;
            }
        }

        public override string Name
        {
            get
            {
                return "金光閃閃的" + weapon.Name;
            }
        }
    }
}
