using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week4
{
    internal class Game
    {
        private List<Character> enemies;
        private int enemyTurnIndex;
        private Player player;


        public void Execute()
        {
            PlayerCreationMenu();
            EnemyCreation();
            GameLoopMenu();
        }

        private void PlayerCreationMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir la vida del jugador");
                int life = int.Parse(Console.ReadLine());
                Console.WriteLine("Introducir el daño del jugador");
                int damage = int.Parse(Console.ReadLine());
                if (damage + life <= 100)
                {
                    continueFlag = false;
                    player = new Player("Player", life, damage);
                }
                else
                {
                    Console.WriteLine("La vida y el daño sumados no pueden ser mayor a 100");
                }
            }
        }

        private void EnemyCreation()
        {
            enemies = new List<Character>();
            enemies.Add(new EnemyMelee("Enemy1", 5, 5));
            enemies.Add(new EnemyMelee("Enemy2", 10, 10));
            enemies.Add(new EnemyRange("EnemyRange1", 15, 15, 2));
            enemies.Add(new EnemyRange("EnemyRange2", 20, 20, 2));

        }

        private void GameLoopMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                PlayerTurnMenu();

                if (EnemiesAlive())
                {
                    EnemyTurnMenu();
                }
                else
                {
                    continueFlag = false;
                }

                if (!player.IsAlive())
                {
                    continueFlag = false;
                }
            }

            if (EnemiesAlive())
            {
                Console.WriteLine("Has perdido");
            }
            else
            {
                Console.WriteLine("Has ganado");
            }
            Console.ReadLine();
        }

        private bool EnemiesAlive()
        {
            foreach (Character enemy in enemies)
            {
                if (enemy.IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        private void PlayerTurnMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Tus datos actuales: ");
                Console.WriteLine(player.GetData());
                Console.WriteLine("Lista de enemigos:");
                for (int i = 0; i < enemies.Count; i++)
                {
                    if (enemies[i].IsAlive())
                    {
                        Console.WriteLine($"{i}. {enemies[i].GetData()}");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. El enemigo está muerto");
                    }
                }
                Console.WriteLine("Introduce el número del enemigo a atacar:");
                int option = int.Parse(Console.ReadLine());
                if (option >= 0 && option < enemies.Count)
                {
                    if (enemies[option].IsAlive())
                    {
                        enemies[option].TakeDamage(player.GetDamage());
                        if (enemies[option].IsAlive())
                        {
                            Console.WriteLine($"Se atacó al enemigo y sus nuevos datos son: {enemies[option].GetData()}");
                        }
                        else
                        {
                            Console.WriteLine("El enemigo murió");
                        }
                        continueFlag = false;
                    }
                    else
                    {
                        Console.WriteLine("El enemigo está muerto, selecciona otro");
                    }
                }
                else
                {
                    Console.WriteLine("La opción está fuera de rango");
                }
            }

        }

        private void EnemyTurnMenu()
        {
            bool continueFlag = true;
            int count = 0;
            while (continueFlag)
            {
                count++;
                if (enemies[enemyTurnIndex].CanAttack())
                {
                    Console.WriteLine($"El enemigo {enemies[enemyTurnIndex].GetData()} va a atacar al jugador");
                    player.TakeDamage(enemies[enemyTurnIndex].GetDamage());
                    continueFlag = false;

                }
                enemyTurnIndex++;
                if (enemyTurnIndex >= enemies.Count)
                {
                    enemyTurnIndex = 0;
                }
                if (count >= enemies.Count)
                {
                    continueFlag = false;
                    Console.WriteLine("Ningún enemigo puede atacar");
                }
            }

        }

    }
}
