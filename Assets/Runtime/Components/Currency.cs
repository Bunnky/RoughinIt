using System;
using UnityEngine;

namespace RoughinIt
{
    [CreateAssetMenu(menuName = "RoughinIt/Currency")]
    public class Currency : ClickerComponent
    {
    }

    [Serializable]
    public struct CurrencyTuple
    {
        public Currency Currency;
        public float Amount;

        public override string ToString()
        {
            return string.Format("{0} {1}s", Amount, Currency.name);
        }
    }
}