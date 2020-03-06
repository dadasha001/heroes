namespace Assets.Scripts.Models.Behaviours
{
    public class Melee : IBehaviour
    {
        public Detachment Detachment { get; private set; }
        public Battleground Battleground { get; private set; }

        public void Control(Battleground battleground, Detachment detachment)
        {
            Battleground = battleground;
            Detachment = detachment;
        }

        public void Attack(Detachment detachment)
        {
            if (Battleground.IsAdjacent(Detachment, detachment))
                Detachment.Attack(detachment);
            else
            {
                (int X, int Y) = Battleground.Position(detachment);

                Move(X, Y);

                if (Battleground.IsAdjacent(Detachment, detachment))
                    Detachment.Attack(detachment);
            }
        }

        public void Move(int x, int y) =>
            Battleground.Move(Detachment, (x, y));
    }
}
