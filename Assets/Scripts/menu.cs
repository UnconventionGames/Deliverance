using UnityEngine;
using UnityEngine.EventSystems;

public class menu : MonoBehaviour, IPointerClickHandler
{
    public GameObject menu_bar;
    private bool is_open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerClick(PointerEventData EventData)
    {
        if (!(EventData.button == PointerEventData.InputButton.Left)){
            return;
        }
        is_open = !is_open;
        menu_bar.SetActive(is_open);
    }
}
