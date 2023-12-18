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

    public List<Executor> executors = new List<Executor>();

    public KeyPressMode mode;
    public KeyCode key;
    
    public virtual void Call()
    {
        foreach (Executor executor in executors)
        {
            if (!executor.Execute())
            {
                return;
            }
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
