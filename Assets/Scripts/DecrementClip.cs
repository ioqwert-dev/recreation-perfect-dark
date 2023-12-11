using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementClip : Action
{
    public Integer currentAmmo;

    public override void execute()
    {
        currentAmmo.data -= 1;
    }
}
