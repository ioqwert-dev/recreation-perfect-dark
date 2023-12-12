using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : Checker
{
    public float fireRate;
    private float _time;

    public override bool Check()
    {
        if (Time.time > _time)
        {
            _time = Time.time + fireRate;
            return true;
        }

        return false;
    }
}
