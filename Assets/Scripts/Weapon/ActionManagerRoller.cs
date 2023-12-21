using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManagerRoller : MonoBehaviour
{
    public List<CallActions> actions = new List<CallActions>();
    public int selected = 0;

    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key)) {
            Increment();
        }

        actions[selected].Interact();
    }

    private void Increment()
    {
        if ((selected + 1) >= actions.Count) {
            selected = 0;
            return;
        }

        selected++;
    }
}
