using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteractable : Interactable
{
    private bool on_bench = false;
    public override void Interact()
    {
        on_bench = !on_bench;
        if (on_bench == true)
        {
            Debug.Log("Sitting in chair.");
        }
        else
        {
            Debug.Log("You stood up.");
        }
    }
}