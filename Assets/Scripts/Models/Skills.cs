namespace Assets.Scripts.Models
{
    public struct Skills
    {
        public int Damage { get; private set; }
        public int Defense { get; private set; }
        public int Speed { get; private set; }

        public Skills(int damage, int defence, int speed)
        {
            Damage = damage;
            Defense = defence;
            Speed = speed;
        }
    }
}
