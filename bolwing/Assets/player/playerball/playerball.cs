using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerball : MonoBehaviour
{
    Renderer invis;
    // Start is called before the first frame update
    void Start()
    {
        invis = GetComponent<MeshRenderer>();
        invis.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        invis.enabled = false;
        if (Input.GetKey(KeyCode.Space)){
            invis.enabled = true;
        }
    }
}
