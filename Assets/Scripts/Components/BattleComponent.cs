using Assets.Scripts.Models;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class BattleComponent : MonoBehaviour
    {
        public Game Game { get; set; }

        public EnemyComponent[] EnemyComponents { get; private set; }
        public PlayerComponent[] PlayerComponents { get; private set; }

        public List<SomeoneComponent> Components { get; private set; }

        private void Start()
        {
            PlayerComponents = FindObjectsOfType<PlayerComponent>();
            EnemyComponents = FindObjectsOfType<EnemyComponent>();

            Components = PlayerComponents.Cast<SomeoneComponent>()
                .Concat(EnemyComponents.Cast<SomeoneComponent>())
                .ToList();

            Step();
        }

        public void Step()
        {
            var detachment = Game.Dequeue();
            var component = Components.First(x => x.Behaviour.Detachment == detachment);

            component.Step(() => Finished(detachment));
        }

        public void Finished(Detachment detachment)
        {
            Game.Enqueue(detachment);

            if (Game.Continues())
                Step();
        }
    }
}