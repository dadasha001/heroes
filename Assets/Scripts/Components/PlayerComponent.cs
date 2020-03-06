using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class PlayerComponent : MonoBehaviour
    {
        public Hero Hero { get; internal set; }

        public void OnMouseDown()
        {
            foreach (var detachment in Hero.Detachments)
                Debug.Log(detachment.Type + " " + detachment.Amount);
        }
    }
}
