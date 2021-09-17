using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    private void OnMouseEnter()
    {
        print("This is ENTER.");

        if (Input.GetMouseButton(0))
        {
            
        }
    }

    private void OnMouseExit()
    {
        print("This is EXIT.");
    }

    void OnMouseDown()
    {
        print("THE THING");

        gameObject.GetComponent<CombatUnit>().register_influence(1);
    }
}
