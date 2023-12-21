using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public List<CallActions> actions = new List<CallActions>();

    void Update()
    {
        foreach (CallActions action in actions) {
            action.Interact();
        }
    }
}
