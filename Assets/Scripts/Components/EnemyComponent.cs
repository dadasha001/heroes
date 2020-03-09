using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class EnemyComponent : SomeoneComponent
    {
        public Hero Enemy { get; set; }

        public override void Step(System.Action finished)
        {
            var index = Random.Range(0, Enemy.Detachments.Count);
            var enemy = Enemy.Detachments[index];

            Behaviour.Attack(enemy);

            finished();
        }
    }
}
