namespace Assets.Scripts.Models.Behaviours
{
    public class Ranged : IBehaviour
    {
        public Detachment Detachment { get; private set; }
        public Battleground Battleground { get; private set; }

        public void Control(Battleground battleground, Detachment detachment)
        {
            Battleground = battleground;
            Detachment = detachment;
        }

        public void Attack(Detachment detachment) =>
            Detachment.Attack(detachment);

        public void Move(int x, int y) =>
            Battleground.Move(Detachment, (x, y));
    }
}
