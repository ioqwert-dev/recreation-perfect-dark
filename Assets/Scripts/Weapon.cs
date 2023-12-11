using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public List<CallActions> actions = new List<CallActions>();
    public KeyCode key;

    void Update()
    {
        if (Input.GetKey(key))
        {
            actions[0].Call();
        }
    }
}
