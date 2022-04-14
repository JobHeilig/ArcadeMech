using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    Collision collision;
    public ParticleSystem particlesystem;
    public bool hit;
    private Animator animator;
    public float timeStop = 1;
    public AudioSource bonk;
    public bool kanHitten;
    // Start is called before the first frame update
    void Start()
    {
        kanHitten = true;
        bonk.Stop();
        animator = GetComponent<Animator>();
        hit = false;
        particlesystem.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "zwaard")
        {
            hit = true;
            //Instantiate(particlesystem);
            particlesystem.Play();
            animator.SetBool("hit", true);
            Debug.Log(kanHitten);
            if (kanHitten == true)
            {
                Debug.Log(kanHitten);
                bonk.Play();
                kanHitten = false;
            }
            
            StartCoroutine(particlestop(timeStop));
        }

    }
    IEnumerator particlestop(float time)
    {
        yield return new WaitForSeconds(time);
        particlesystem.Stop();
    }
}
