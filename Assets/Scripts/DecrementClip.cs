using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementClip : Executor
{
    public Integer currentAmmo;

    public override void Execute()
    {
        currentAmmo.data -= 1;
    }
}
