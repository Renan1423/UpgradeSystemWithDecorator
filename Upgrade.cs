using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade : ScriptableObject
{
    public abstract void TriggerUpgrade();

    public abstract void UntriggerUpgrade();
}
