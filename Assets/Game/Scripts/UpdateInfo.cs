using System.Linq;
using RoughinIt;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfo : MonoBehaviour
{
    public ClickerManager Manager;
    public Text Money;
    public Text Upgrades;
    public Text Buildings;

    void Start()
    {
        Manager.OnTick.AddListener(OnTick);
        Manager.OnBuyBuilding.AddListener(OnBuyBuilding);
        Manager.OnBuyUpgrade.AddListener(OnBuyUpgrade);
        OnTick();
        OnBuyBuilding();
        OnBuyUpgrade();
    }

    private void OnTick()
    {
        Money.text = "Current Resources: " + "\n" + string.Join("\n", Manager.State.CurrencyCurrentTotals.Select((kvp) => string.Format("{0} {1}", kvp.Key.name, kvp.Value)).ToArray());
    }

    private void OnBuyUpgrade()
    {
        Upgrades.text = "Current Upgrades: " + "\n" + string.Join(", ", Manager.State.EarnedUpgrades.Select(upgrade => upgrade.name).ToArray());
    }

    private void OnBuyBuilding()
    {
        Buildings.text = "Current Buildings: " + "\n" + string.Join(", ", Manager.State.EarnedBuildings.Select((kvp) => string.Format("{0} {1}", kvp.Key.name, kvp.Value)).ToArray());
    }
}