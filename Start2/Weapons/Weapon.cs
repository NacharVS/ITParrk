using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class Weapon
    {
        public int minDamage;
        public int maxDamage;
        public int rateOfFire;
        public string color;
        public double weight;
        public int clip;
        public bool canBurstShooting;

        public Weapon(int minDamage, int maxDamage, int rateOfFire, string color, double weight, bool canBurstShooting)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.rateOfFire = rateOfFire;
            this.color = color;
            this.weight = weight;
            clip = 20;
            this.canBurstShooting = canBurstShooting;
        }

        public void Info()
        {
            Console.WriteLine($"Weapon - Pistol. minDamage {minDamage} maxDamage {maxDamage} Clip: {clip}");
        }
        public void Shoot()
        {
            if (clip > 0)
            {
                Random random = new Random();
                Console.WriteLine($"Piu! Inflicted Damage {random.Next(minDamage, maxDamage)}");
                clip = clip - 1;
            }
            else
            {
                Console.WriteLine("Clip is empty");
            }
        }

        public void BurstShoot()
        {
            if (canBurstShooting)
            {
                Shoot();
                Shoot();
                Shoot();
            }
            else
                Shoot();
        }
    }
}
