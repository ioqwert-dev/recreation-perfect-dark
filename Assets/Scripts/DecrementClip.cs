using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementClip : Executor
{
    public Integer currentAmmo;
    public int amount;

    public override bool Execute()
    {
        currentAmmo.data -= amount;
        return true;
    }
}
