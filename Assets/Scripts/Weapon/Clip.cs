using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : Executor
{
    public Integer currentAmmo;

    public override bool Execute()
    {
        return currentAmmo.data > 0;
    }
}
