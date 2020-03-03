using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class GameComponent : MonoBehaviour
    {
        public GameObject Grid;

        public Hero Hero;
        public Game Game;

        private void Start()
        {
            Game = new Game();

            var grid = Instantiate(Grid, transform);
            var gridComponent = grid.GetComponent<GridComponent>();

            gridComponent.Grid = Game.Grid;
            gridComponent.Game = Game;

            var playerDisplayComponent = FindObjectOfType<PlayerDisplayComponent>();
            playerDisplayComponent.Hero = Game.Heroes[0];

            var enemyDisplayComponent = FindObjectOfType<EnemyDisplayComponent>();
            enemyDisplayComponent.Hero = Game.Heroes[1];

            //while (Game.Continue())
            //{
            //    var current = Game.Detachments.Dequeue();
            //    current.Step();
            //    Game.Detachments.Enqueue(current);
            //}
        }
    }
}
