using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 Direction = new Vector2(moveHorizontal, moveVertical);

        transform.position = Vector2.SmoothDamp(transform.position, (Vector2)transform.position + Direction, ref velocity, Time.deltaTime);
    }
}