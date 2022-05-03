namespace Sapt1
{
    class Player 
    {
        private int health;
        private int damage;

        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }

        public Player() : this(100, 10)
        {
        }

        public Player(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }        
    }
}