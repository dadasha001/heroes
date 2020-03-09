using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class GameComponent : MonoBehaviour
    {
        public GameObject Grid;
        public GameObject BattleComponent;

        public Hero Hero;
        public Game Game;

        private void Start()
        {
            Game = new Game();

            var grid = Instantiate(Grid, transform);
            var gridComponent = grid.GetComponent<GridComponent>();

            gridComponent.Battleground = Game.Battleground;
            gridComponent.Game = Game;

            var battle = Instantiate(BattleComponent, transform);
            var battleComponent = battle.GetComponent<BattleComponent>();
            battleComponent.Game = Game;

            var playerDisplayComponent = FindObjectOfType<PlayerDisplayComponent>();
            playerDisplayComponent.Hero = Game.Heroes[0];

            var enemyDisplayComponent = FindObjectOfType<EnemyDisplayComponent>();
            enemyDisplayComponent.Hero = Game.Heroes[1];
        }
    }
}
