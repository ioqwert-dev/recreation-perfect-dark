using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownActive : Checker
{
    public Cooldown cooldown;

    public override bool Check()
    {
        return !cooldown.Check();
    }
}
