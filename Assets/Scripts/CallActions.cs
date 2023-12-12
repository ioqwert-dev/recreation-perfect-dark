using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallActions : MonoBehaviour
{
    public List<Checker> checkers = new List<Checker>();
    public List<Executor> executors = new List<Executor>();
    
    public void Call() 
    {
        foreach (Checker checker in checkers)
        {
            if (!checker.Check())
            {
                return;    
            }
        }

        foreach (Executor executor in executors)
        {
            executor.Execute();
        }
    }
}
