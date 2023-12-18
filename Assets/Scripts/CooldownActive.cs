using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownActive : Executor
{
    public Cooldown cooldown;

    public override bool Execute()
    {
        return Time.time > cooldown._time;
    }
}
