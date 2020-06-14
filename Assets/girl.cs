using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl : MonoBehaviour
{
    [SerializeField] KeyCode Jump;
    [SerializeField] KeyCode Slide;
    public float jumpSpeed;
    public float slideSpeed;
    Rigidbody2D rb;
    Animator am;
    int jump;
    int slide;
    Renderer rend;

    //Use this for initialzation
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        jump = 0;
        slide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Jump) && jump < 2)
        {
            jump++;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            am.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        else if  (Input.GetKey(Slide) && slide < 1)
        {
            slide++;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            am.SetBool("Slide", true);
            rb.velocity = new Vector2(rb.velocity.x,slideSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        jump = 0;
        am.SetBool("Jump", false);

        slide = 0;
        am.SetBool("Slide", false);
    }
}
    


