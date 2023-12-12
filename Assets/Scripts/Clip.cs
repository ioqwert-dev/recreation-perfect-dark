using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : Checker
{
    public Integer currentAmmo;

    public override bool Check()
    {
        return currentAmmo.data > 0;
    }
}
