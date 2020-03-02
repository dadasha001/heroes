using Assets.Scripts.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class PlayerDisplayComponent : MonoBehaviour
    {
        public Text Detachments;

        public Hero Hero;

        private void Update()
        {
            Detachments.text = Hero.Detachments[0].Type + " " + Hero.Detachments[0].Amount + "\n" +
                Hero.Detachments[1].Type + ": " + Hero.Detachments[1].Amount + "\n" +
                Hero.Detachments[2].Type + ": " + Hero.Detachments[2].Amount + "\n" +
                Hero.Detachments[3].Type + ": " + Hero.Detachments[3].Amount + "\n" +
                Hero.Detachments[4].Type + ": " + Hero.Detachments[4].Amount + "\n" +
                Hero.Detachments[5].Type + ": " + Hero.Detachments[5].Amount + "\n" +
                Hero.Detachments[6].Type + ": " + Hero.Detachments[6].Amount + "\n";
        }
    }
}
