namespace Assets.Scripts.Models.Behaviours
{
    public abstract class Behaviour
    {
        public Detachment Detachment;

        public abstract void Step();

        public abstract void Attack(Detachment detachment, Game game);
    }
}
