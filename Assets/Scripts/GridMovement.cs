using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public Grid grid;
    public float tile_size;

    public bool isMoving = false;
    Vector3 destination;
    Vector3 direction_distance;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Debug.Log(grid.WorldToCell(mouseposition));
            destination = grid.GetCellCenterWorld(grid.WorldToCell(mouseposition));
            direction_distance = destination - transform.position;
            Debug.Log(direction_distance);
            isMoving = true;
        }
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            //rb.MovePosition(Vector2.MoveTowards(transform.position, destination, .1f));
            
            if(direction_distance.x != 0)
            {
                if(direction_distance.x > 0)
                {
                    
                }
                else
                {
                    rb.MovePosition(Vector2.MoveTowards(transform.position, Vector2.right, 1));
                }
            }
            rb.MovePosition(Vector2.MoveTowards(transform.position, Vector2.left, 1));
            if ((destination - transform.position).magnitude <= 0.05f)
            {
                transform.position = destination;
                isMoving = false;
            }
        }
    }
}