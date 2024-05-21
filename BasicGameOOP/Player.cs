using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGameOOP
{
    internal class Player : Character
    {
        public Player(string name) : base(name, 100, 15, 10)
        {

        }

        public void Attack(Enemy enemy, bool useMagic)
        {
            Random random = new Random();
            //determine damage based on random and current stats
            int damage = useMagic ? MagicAttack + random.Next(5, 10) : PhysicalAttack + random.Next(5, 10);
            Console.WriteLine($"{Name} attacks {enemy.Name} for {damage}");
            enemy.TakeDamage(damage);
        }
    }
}
    
