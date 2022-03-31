using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public Rigidbody rb;
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
    }
}
