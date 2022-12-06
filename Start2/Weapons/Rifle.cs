using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class Rifle : Weapon
    {
        public Rifle(int minDamage, int maxDamage, int rateOfFire, string color, double weight, bool canBurstShooting) : base(minDamage, maxDamage, rateOfFire, color, weight, canBurstShooting)
        {
        }
    }
}
