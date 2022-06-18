using System;
using UnityEngine;

namespace RoughinIt
{
    [CreateAssetMenu(menuName = "RoughinIt/Building")]
    public class Building : UnlockableComponent
    {
        public CurrencyTuple Cost;
        public CurrencyTuple YieldAmount;
    }

    [Serializable]
    public struct BuildingTuple
    {
        public Building Building;
        public int Amount;
    }
}