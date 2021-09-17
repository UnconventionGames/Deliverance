using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagement : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

/*
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        print(hit.collider != null);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
            hit.collider.attachedRigidbody.AddForce(Vector2.up);
        }
    }

*/
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
