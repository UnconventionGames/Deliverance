using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue_text : MonoBehaviour
{
    // Start is called before the first frame update
    public Text dialogue;
    [TextArea]
    public string dialogueText;
    void Start()
    {
        dialogue.text = dialogueText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void set_text (string new_text)
    {
        dialogue.text = new_text;
        dialogueText = new_text;
    }
}
