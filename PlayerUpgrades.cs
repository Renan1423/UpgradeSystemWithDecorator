using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgrades : MonoBehaviour
{
    private UpgradeDecorator upgrade;

    public void AddUpgrade(UpgradeDecorator upgrade)
    {
        if(this.upgrade != null)
            this.upgrade.UntriggerUpgrade();

        UpgradeDecorator upgradeInstance = ScriptableUtils.Clone(upgrade);

        upgradeInstance.StackUpgrade(this.upgrade);
        upgradeInstance.TriggerUpgrade();
        this.upgrade = upgradeInstance;
    }
}
