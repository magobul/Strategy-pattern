using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы используете меч. Наносите резкий удар!");
        }
    }
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы используете лук. Стреляете стрелами!");
        }
    }

    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы используете топор. Наносите рубящий удар!");
        }
    }
    public class Hammer : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы используете молот. Наносите мощный удар!");
        }
    }
    public class Spear : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы используете копье. Наносите колющий удар!");
        }
    }
}