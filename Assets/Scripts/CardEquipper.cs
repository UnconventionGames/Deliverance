using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardEquipper : MonoBehaviour
{
    private int[] equipment = new int[6];

    // Start is called before the first frame update
    void Start()
    {
        equipment[0] = 5;
        print(gameObject.transform.GetChild(0).GetChild(0).GetComponent<Text>().text) ;
        gameObject.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "ahh";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
