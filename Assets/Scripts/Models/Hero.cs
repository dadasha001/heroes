using System.Collections.Generic;

namespace Assets.Scripts.Models
{
    public class Hero
    {
        public List<Detachment> Detachments { get; private set; }

        public Hero() =>
            Detachments = new List<Detachment>();

        public void Add(Unit.Type type, int amount) =>
            Detachments.Add(new Detachment(type, amount));
    }
}
