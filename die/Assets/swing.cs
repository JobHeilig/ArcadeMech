using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    Collision collision;
    public bool hit;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "zwaard")
        {
            hit = true;
            animator.SetBool("hit", true);
            Debug.Log("true");
        }

    }

}
