using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallActions : MonoBehaviour
{
    public enum KeyPressMode
    {
        Up,
        Down,
        Hold
    }

    public List<Checker> checkers = new List<Checker>();
    public List<Executor> executors = new List<Executor>();

    public KeyPressMode mode;
    public KeyCode key;
    
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

    public void Interact()
    {
        if (mode == KeyPressMode.Up)
        {
            if (Input.GetKeyUp(key))
            {
                Call();
            }
        }
        else if (mode == KeyPressMode.Down)
        {
            if (Input.GetKeyDown(key))
            {
                Call();
            }
        } 
        else if (mode == KeyPressMode.Hold)
        {
            if (Input.GetKey(key))
            {
                Call();
            }
        }
    }
}
