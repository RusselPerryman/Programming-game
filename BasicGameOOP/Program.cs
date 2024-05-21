using System;

namespace BasicGameOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player("Player 1");
            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy("Goblin King", 50, 1, 10),
                new Enemy("Goblin Minion", 10,1,5)
            };

            Room cave = new Room("You are in a dark cave", enemies);
            cave.Enter(player);

            while (player.IsAlive() && enemies.Count > 0)
            {
                Console.WriteLine("Choose an action: [A]ttack with Strength, [M]agic Attack");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == 'A' || input == 'a')
                {
                    player.Attack(enemies[0], false);
                }
                else if (input == 'M' || input == 'm')
                {
                    player.Attack(enemies[0], true);
                }

                if (!enemies[0].IsAlive())
                {
                    Console.WriteLine($"{enemies[0].Name} is dead, GG,EZ, GET GOOD");
                    enemies.RemoveAt(0);
                }
                else
                {
                    foreach (var enemy in enemies)
                    {
                        player.TakeDamage(player.PhysicalAttack / 2);
                        Console.WriteLine($"{enemy.Name} attacks {player.Name} for {player.PhysicalAttack / 2} damage");
                    }
                }
                Console.WriteLine($"{player.Name} Health: {player.Health}");
                foreach (var enemy in enemies)
                {
                    Console.WriteLine($"{enemy.Name} Health: {enemy.Health}");
                }

            }
            if (player.IsAlive())
            {
                Console.WriteLine("You have defeated all enemies, well done!");
            }
            else
            {
                Console.WriteLine("Get good");
            }
            
            List<Enemy> mountainEnemies = new List<Enemy>
            {
                new Enemy("Dragon", 500, 99, 50),
                new Enemy("Dark Knights", 50,1,20)
            };
            Room mountainPass = new Room("You are atop a mountain", mountainEnemies);
            mountainPass.Enter(player);
            while (player.IsAlive() && mountainEnemies.Count > 0)
            {
                Console.WriteLine("Choose an action: [A]ttack with Strength, [M]agic Attack");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == 'A' || input == 'a')
                {
                    player.Attack(mountainEnemies[0], false);
                }
                else if (input == 'M' || input == 'm')
                {
                    player.Attack(mountainEnemies[0], true);
                }

                if (!mountainEnemies[0].IsAlive())
                {
                    Console.WriteLine($"{mountainEnemies[0].Name} is dead, GG,EZ, GET GOOD");
                    enemies.RemoveAt(0);
                }
                else
                {
                    foreach (var enemy in mountainEnemies)
                    {
                        player.TakeDamage(player.PhysicalAttack / 2);
                        Console.WriteLine($"{enemy.Name} attacks {player.Name} for {player.PhysicalAttack / 2} damage");
                    }
                }
                Console.WriteLine($"{player.Name} Health: {player.Health}");
                foreach (var enemy in mountainEnemies)
                {
                    Console.WriteLine($"{enemy.Name} Health: {enemy.Health}");
                }

            }



        }
    }
}