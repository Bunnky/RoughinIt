using System;
using UnityEngine;

namespace RoughinIt
{
    [CreateAssetMenu(menuName = "RoughinIt/Clickable")]
    public class Clickable : ClickerComponent
    {
        public Currency Currency;
        public float Amount;
    }
}