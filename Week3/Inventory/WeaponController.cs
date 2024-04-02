using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class WeaponController
    {
        private List<Weapon> weapons;

        public WeaponController()
        {
            weapons = new List<Weapon>();
        }

        public void Execute()
        {
            Menu();
        }

        private void Menu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número de la opción deseada");
                Console.WriteLine("1. Agregar arma");
                Console.WriteLine("2. Mostrar armas");
                Console.WriteLine("3. Eliminar arma");
                Console.WriteLine("4. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddWeaponMenu();
                        break;
                    case "2":
                        ShowWeapons();
                        break;
                    case "3":
                        RemoveWeapon();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void AddWeaponMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Espada");
                Console.WriteLine("2. Pistola");
                Console.WriteLine("3. Arco");
                Console.WriteLine("4. Regresar");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        weapons.Add(GetSword());
                        continueFlag = false;
                        break;
                    case "2":
                        weapons.Add(GetPistol());
                        continueFlag = false;
                        break;
                    case "3":
                        weapons.Add(GetBow());
                        continueFlag = false;
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }
        }

        private Sword GetSword()
        {
            Console.WriteLine("Introduce el nombre de la espada");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el precio de la espada");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la espada");
            float damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque de la espada");
            float attackSpeed = float.Parse(Console.ReadLine());
            return new Sword(name, price, damage, attackSpeed);
        }
        private Pistol GetPistol()
        {
            Console.WriteLine("Introduce el nombre de la pistola");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el precio de la pistola");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la pistola");
            float damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque de la pistola");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la bala");
            float bulletPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la bala");
            float bulletDamage = float.Parse(Console.ReadLine());
            return new Pistol(name, price, damage, attackSpeed, new Bullet(bulletPrice, bulletDamage));
        }

        private Bow GetBow()
        {
            Console.WriteLine("Introduce el nombre del arco");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el precio del arco");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño del arco");
            float damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque del arco");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la flecha");
            float arrowPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la flecha");
            float arrowDamage = float.Parse(Console.ReadLine());
            return new Bow(name, price, damage, attackSpeed, new Arrow(arrowPrice, arrowDamage));
        }

        private void ShowWeapons()
        {
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.GetData());
            }
        }

        private void RemoveWeapon()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Indica el número del arma a eliminar");
                for (int i = 0; i < weapons.Count; i++)
                {
                    Console.WriteLine($"{i}. {weapons[i].GetData()}");
                }

                int option = int.Parse(Console.ReadLine());

                if (option >= 0 && option < weapons.Count)
                {
                    weapons.RemoveAt(option);
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                }
            }
        }


    }
}
