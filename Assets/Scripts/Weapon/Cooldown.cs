using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : Executor
{
    public float fireRate;
    [HideInInspector] public float _time;

    public override bool Execute()
    {
        if (Time.time > _time)
        {
            _time = Time.time + fireRate;
            return true;
        }

        return false;
    }
}
