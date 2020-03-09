using Assets.Scripts.Models.Behaviours;
using System;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public abstract class SomeoneComponent : MonoBehaviour
    {
        public IBehaviour Behaviour { get; set; }

        public abstract void Step(Action finished);
    }
}
