using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public int shot = 1;
    Collision collision;
    Renderer invis;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        invis = GetComponent<MeshRenderer>();
        invis.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && shot == 1)
        {
            transform.position += transform.right * Time.deltaTime * 2;
            //rb.AddForce(20, 0, 0);
            //rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
            
        }
        if (Input.GetKey(KeyCode.A) && shot == 1)
        {
            transform.position -= transform.right * Time.deltaTime * 2;
            //rb.AddForce(20, 0, 0);
            //rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.Space) && shot == 1)
        {
            //transform.position += transform.right * Time.deltaTime * 5;
            //rb.AddForce(20, 0, 0, ForceMode.Impulse);
            //rb.velocity = new Vector3(30, rb.velocity.y, rb.velocity.z);
            rb.velocity = transform.forward * 30;
            shot = 0;


        }
        if (Input.GetKey(KeyCode.R))
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(0, 0.5f, 0);
            transform.rotation = new Quaternion(0, 0, 0, 0);

            shot = 1;
            rb.rotation = Quaternion.identity;
            rb.freezeRotation = true;
        }
        if (shot == 1)
        {
            rb.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0, 0, 0);
            rb.useGravity = false;
            invis.enabled = false;
            rb.freezeRotation = false;
        }
        if (shot == 0)
        {
            
            rb.useGravity = true;
            invis.enabled = true;
        }


        }
}
