using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("2. Сменить оружие");
                Console.WriteLine("3. Выйти");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _player.Attack();
                        break;
                    case "2":
                        ChangeWeapon();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте снова.");
                        break;
                }
            }
        }

        private void ChangeWeapon()
        {
            Console.WriteLine("Выберите новое оружие:");
            Console.WriteLine("1. Меч");
            Console.WriteLine("2. Лук");
            Console.WriteLine("3. Топор");
            Console.WriteLine("4. Молот");
            Console.WriteLine("5. Копье");

            var choice = Console.ReadLine();
            IWeapon newWeapon = null;

            switch (choice)
            {
                case "1":
                    newWeapon = new Sword();
                    break;
                case "2":
                    newWeapon = new Bow();
                    break;
                case "3":
                    newWeapon = new Axe();
                    break;
                case "4":
                    newWeapon = new Hammer();
                    break;
                case "5":
                    newWeapon = new Spear();
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Оружие не изменено.");
                    return;
            }

            _player.SetWeapon(newWeapon);
            Console.WriteLine("Оружие успешно изменено!");
        }
    }
}
