using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedRepeat : Executor
{
    public float time;
    public int times;
    public List<Executor> executors = new List<Executor>();

    public override bool Execute()
    {
        StartCoroutine(WaitToExecute());

        return true;
    }

    IEnumerator WaitToExecute()
    {
        for (int i = 0; i < times; i++) {
            foreach (Executor executor in executors)
            {
                if (!executor.Execute())
                {
                    yield break;
                }
            }

            yield return new WaitForSeconds(time);
        }
    }
}
