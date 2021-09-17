using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Left"))
        {
            print("Left");
            transform.Translate(-1, 0, 0, Space.World);
        }

        if (Input.GetButtonDown("Right"))
        {
            print("Right");
            transform.Translate(1, 0, 0, Space.World);
        }

        if (Input.GetButtonDown("Up"))
        {
            print("Up");
            transform.Translate(0, 1, 0, Space.World);
        }

        if (Input.GetButtonDown("Down"))
        {
            print("Down");
            transform.Translate(0, -1, 0, Space.World);
        }
    }
}
