namespace Assets.Scripts.Models.Behaviours
{
    public interface IBehaviour
    {
        Detachment Detachment { get; }
        Battleground Battleground { get; }

        void Control(Battleground battleground, Detachment detachment);

        void Attack(Detachment detachment);

        void Move(int x, int y);
    }
}
