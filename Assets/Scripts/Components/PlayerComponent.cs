using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class PlayerComponent : SomeoneComponent
    {
        private bool _selecting;
        private System.Action _finished;

        public override void Step(System.Action finished)
        {
            if (_selecting)
                throw new System.Exception("Step is already in progress.");

            _selecting = true;
            _finished = finished;
        }

        private void OnClick()
        {
            if (!_selecting)
                return;

            (int, int) position;

            var clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var x = (int) Mathf.Round(clickedPosition.x);
            var y = (int) Mathf.Round(clickedPosition.y);

            position = (x, y);

            if (Game.Battleground[position] != null)
                component.Step(Game.Battleground[x, y]);
            else
                component.Step(x, y);

            Behaviour.Attack(detachment);

            var finished = _finished;

            _selecting = false;
            _finished = null;

            finished();
        }
    }
}
