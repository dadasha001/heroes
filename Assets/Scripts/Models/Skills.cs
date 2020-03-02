namespace Assets.Scripts.Models
{
    public struct Skills
    {
        public int Damage { get; private set; }
        public int Defence { get; private set; }
        public int Speed { get; private set; }

        public Skills(int damage, int defence, int speed)
        {
            Damage = damage;
            Defence = defence;
            Speed = speed;
        }
    }
}
