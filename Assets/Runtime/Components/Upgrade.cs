﻿using System;
using UnityEngine;

namespace RoughinIt
{
    [CreateAssetMenu(menuName = "RoughinIt/Upgrade")]
    public class Upgrade : UnlockableComponent
    {
        public CurrencyTuple Cost;
        public UpgradePerk[] UpgradePerk;
    }

    [Serializable]
    public enum UpgradeType
    {
        Currency,
        Building,
        Clickable
    }

    [Serializable]
    public class UpgradePerk
    {
        public UpgradeType Type;
        public Building TargetBuilding;
        public Clickable TargetClickable;
        public Currency TargetCurrency;
        public Operation Operation;
        public float Amount;
    }

    public enum Operation
    {
        Add,
        Multiply
    }
}