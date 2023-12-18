using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : Executor
{
    public Integer ammo;

    public override bool Execute()
    {
        ammo.data = 30;

        return true;
    }
}
