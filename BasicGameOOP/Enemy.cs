using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGameOOP
{
    public class Enemy : Character
    {
        public Enemy(string name, int health, int magicAttack, int physicalAttack) : base(name, health, magicAttack, physicalAttack)
        {
        }
    }
}
