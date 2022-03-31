using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xbot : MonoBehaviour
{
    public bool A;
    public bool D;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && A)
        {
            transform.Rotate(0, -180, 0);
            A = false;
            D = true;
            
        }
        if (Input.GetKey(KeyCode.D) && D)
        {
            transform.Rotate(0, 180, 0);
            A = true;
            D = false;

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walking", true);
        }
        if (!(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.D)))
        {
            animator.SetBool("walking", false);
        }
    }
}
