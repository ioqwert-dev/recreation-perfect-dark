using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallActions : MonoBehaviour
{
    public List<Checker> checkers = new List<Checker>();
    public List<Action> actions = new List<Action>();
    
    public void Call() 
    {
        foreach (Checker checker in checkers)
        {
            if (!checker.check())
            {
                return;    
            }
        }

        foreach (Action action in actions)
        {
            action.execute();
        }
    }
}
