namespace Sapt1
{
    public delegate void DamageTakenDelegate(int damage);
    class Monster 
    {
        private int health;
        private int damage;

        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }

        public event DamageTakenDelegate OnDamageTaken;

        public Monster() : this(100, 10)
        {
        }

        public Monster(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }

        public void TakeDamage(int damage)
        {
            this.health -= damage;
            // if (DamageTaken != null) {
            //     DamageTaken(damage);
            // }
            OnDamageTaken?.Invoke(damage);
        }
    }
}