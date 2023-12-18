using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : Executor
{
    public Executor execute;
    public float time;

    public override bool Execute()
    {
        StartCoroutine(WaitTo());

        return true;
    }

    IEnumerator WaitTo()
    {
        yield return new WaitForSeconds(time);

        execute.Execute();
    }
}
