using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDecorator : Upgrade
{
    protected Upgrade _upgrade;

    public void StackUpgrade(Upgrade upgrade) 
    {
        _upgrade = upgrade;
    }

    public override void TriggerUpgrade()
    {
        if(_upgrade != null)
            _upgrade.TriggerUpgrade();
    }

    public override void UntriggerUpgrade()
    {
        if (_upgrade != null)
            _upgrade.UntriggerUpgrade();
    }
}
