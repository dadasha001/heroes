using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
