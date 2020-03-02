using System;

namespace Assets.Scripts.Models
{
    public class Detachment
    {
        public readonly Unit.Type Type;

        public int Amount { get; private set; }
        public int Health { get; private set; }
        public int Speed { get; private set; }

        public Detachment(Unit.Type type, int amount)
        {
            Type = type;
            Amount = amount;
            Health = Amount * Settings.Units.Health(Type);
            Speed = Settings.Units.Parameters(Type).Speed;
        }

        public void Attack(Detachment detachment) =>
            detachment.ReceiveDamage(Damage);

        public void ReceiveDamage(int value)
        {
            //TODO: Amount change.
            Health -= value - Defense;
        }

        public void Step()
        {

        }

        public int Damage => 
            Amount * Settings.Units.Parameters(Type).Damage;

        public int Defense =>
            Amount * Settings.Units.Parameters(Type).Defense;
    }
}
