using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGameOOP
{
    internal class Room
    {
        public string Description { get; set; }
        public List<Enemy> Enemies { get; private set; }

        public Room(string description, List<Enemy> enemies)
        {
            Description = description;
            Enemies = enemies;
        }

        public void Enter(Player player)
        {
            Console.WriteLine(Description);
            if (Enemies.Count > 0)
            {
                Console.WriteLine($"Enemies in the room: {Enemies.Count}");
            }
        }
    }
}
