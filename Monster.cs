namespace Sapt1
{
    class Monster 
    {
        private int health;
        private int damage;

        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }

        public Monster() : this(100, 10)
        {
        }

        public Monster(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }
    }
}