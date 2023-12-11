using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : Checker
{
    public Integer currentAmmo;

    public override bool check()
    {
        if (currentAmmo.data <= 0)
        {
            return false;
        }

        return true;
    }
}
