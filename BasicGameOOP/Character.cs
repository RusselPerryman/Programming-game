using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGameOOP
{
    public class Character
    {
        //stats for all characters
        public string Name { get; set; }

        public int Health { get; set; }


        public int MagicAttack { get; set; }

        public int PhysicalAttack { get; set; }


        //Constructor
        public Character(string name, int health, int magicAttack, int physicalAttack)
        {
            Name = name;
            Health = health;
            MagicAttack = magicAttack;
            PhysicalAttack = physicalAttack;
        }
        //Void doesn't need to return values
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if(Health < 0)
            {
                Health = 0;
            }
        }
        //Returns values
        public bool IsAlive()
        {
            return Health > 0;
        }


    }
}
