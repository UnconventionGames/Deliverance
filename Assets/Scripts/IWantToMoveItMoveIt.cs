using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWantToMoveItMoveIt : MonoBehaviour
{
    public float maxrunmultiplier = 2f;
    float currentrunmultiplier = 1f;
    public float speed = 10f;
    Rigidbody2D rb;
    Animator anim;
    public Vector2 BoxSize = new Vector2(1f, 1f);
    public Vector2 BoxOffset = new Vector2(1f, 2f);
    public float dash_speed;
    private float dash_time;
    public float start_dash_time;
    private int direction;
    private bool is_dashing = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent < Rigidbody2D > ();
        anim = GetComponent < Animator > ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
        CheckInteraction();    
        }
        if (Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift)){
            currentrunmultiplier = maxrunmultiplier;
            anim.SetBool("IsRunning", true);
        }
        else {
            currentrunmultiplier = 1f;
            anim.SetBool("IsRunning", false);
        }
        Vector2 dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(dir.magnitude <= 1){
            rb.velocity = dir*speed*currentrunmultiplier;
        }
        else{
            rb.velocity = dir.normalized * speed*currentrunmultiplier;
        }
        anim.SetFloat("Speed", rb.velocity.magnitude);
        if (direction == 0)
        {
            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                direction = 1;
            }
            else if (Input.GetAxisRaw("Horizontal") == 1)
            {
                direction = 2;
            }
            else if (Input.GetAxisRaw("Vertical") == 1)
            {
                direction = 3;
            }
            else if (Input.GetAxisRaw("Vertical") == -1)
            {
                direction = 4;
            }
        }
        else {
            if (dash_time <= 0)
            {
                direction = 0;
                dash_time = start_dash_time;
                is_dashing = false;
            }
            else 
            {
                if (is_dashing == true)
                {
                    dash_time = dash_time - Time.deltaTime;
                    if (direction == 1)
                    {
                        rb.velocity += Vector2.left * dash_speed;
                    }
                    else if (direction == 2)
                    {
                        rb.velocity += Vector2.right * dash_speed;
                    }
                    else if (direction == 3)
                    {
                        rb.velocity += Vector2.up * dash_speed;
                    }
                    else if (direction == 4)
                    {
                        rb.velocity += Vector2.down * dash_speed;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Space))
                {
                    is_dashing = true;
                }
            }
        }
    }
    void CheckInteraction()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position + (Vector3)BoxOffset, BoxSize, 0, Vector2.zero);
        if (hits.Length > 0)
        {
            foreach(RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent < Interactable >())
                {
                    rc.transform.GetComponent < Interactable >().Interact();
                    return;
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position + (Vector3)BoxOffset, new Vector3(BoxSize.x, BoxSize.y, 0));
    }
}