using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class Pistol : Weapon
    {
        public int a;
        public Pistol(int minDamage, int maxDamage, int rateOfFire, string color, double weight, bool canBurstShooting) 
            : base(minDamage, maxDamage, rateOfFire, color, weight, canBurstShooting)
        {
            
        }

        public void PhysicalHit()
        {
            Console.WriteLine(" Bam! ");
        }
    }
}
