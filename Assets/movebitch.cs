using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebitch : MonoBehaviour
{


    public float moveSpeed = 6f;
    public float jumpspeed = 12f;
    private Rigidbody2D rbody;
    public GroundChecker groundchecker;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            if (groundchecker.isgrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);
            }




        }
    }
    private void OnTriggerStay2D(Collider2D collision)

    {
        if (collision.tag == "Stege")
        {
            rbody.velocity = new Vector2(Input.GetAxis("Vertical") * moveSpeed, rbody.velocity.x);
        }
    }
}


  
  
            

	
	