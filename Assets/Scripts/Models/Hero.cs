using System;
using System.Collections.Generic;

namespace Assets.Scripts.Models
{
    public class Hero
    {
        public List<Detachment> Detachments { get; private set; }

        public Hero() =>
            Detachments = new List<Detachment>();

        public void Add(Detachment detachment)
        {
            if (Detachments.Count >= Settings.Detachments.Limit)
                throw new Exception("Exceeding the limit of detachments!");

            Detachments.Add(detachment);
        }

        public void Add(Unit.Type type, int amount) =>
            Add(new Detachment(type, amount));
    }
}

