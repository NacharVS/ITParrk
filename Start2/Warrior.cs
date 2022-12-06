using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    class Warrior
    {
        public string name;
        public int health;
        public int minDamage;
        public int maxDamage;

        public Warrior()
        {

        }

        public Warrior(string name)
        {
            this.name = name;
            this.health = 100;
            this.minDamage = 5;
            this.maxDamage = 10;
        }

        public Warrior(string name, int health) : this(name)
        {
            this.health = health;
            this.minDamage = 10;
            this.maxDamage = 30;
        }
    }
}
