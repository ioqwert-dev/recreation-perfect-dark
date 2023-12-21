using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Executor
{
    public override bool Execute()
    {
        Debug.Log("Shoot");

        return true;
    }
}
