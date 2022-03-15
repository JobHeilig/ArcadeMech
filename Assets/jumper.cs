using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    public Rigidbody rb;
    public int grond = 0;
    Collision collision;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position -= transform.right * Time.deltaTime * 5;
            //rb.AddForce(-20, 0, 0);
            rb.velocity = new Vector3(-5, rb.velocity.y, rb.velocity.z);
        }


        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += transform.right * Time.deltaTime * 5;
            //rb.AddForce(20, 0, 0);
            rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.Space) && grond == 1)
        {
            // transform.position += new Vector3(0, 10, 0) * Time.deltaTime;
            rb.velocity= new Vector3(rb.velocity.x, 10, rb.velocity.z);

        }
        if (Input.GetKey(KeyCode.T))
        {
            grond = 1;
        };


    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grond = 1;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grond = 0;
        }
    }

}
