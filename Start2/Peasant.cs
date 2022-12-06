using System;

namespace Start2
{
    class Peasant
    {
        public string name;
        public int price;
        public int health;
        public int speed;
        public int minDamage;
        public int maxDamage;
        public int maXWeight;
        

        public Peasant()
        {
        }

        public Peasant(string name, int price, int health, int speed, int minDamage, int maxDamage, int maXWeight)
        {
            this.name = name;
            this.price = price;
            this.health = health;
            this.speed = speed;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.maXWeight = maXWeight;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit - Peasant. Name - {name} Health - {health} Speed - {speed}");
        }

        public void InflictDamage(Peasant unit)
        {
            Random random = new Random();
            unit.health = unit.health - random.Next(minDamage, maxDamage);
        }


    }
}
