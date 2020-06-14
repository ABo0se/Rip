using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opp : MonoBehaviour
{
    [SerializeField] KeyCode oppJump;
    [SerializeField] KeyCode oppSlide;
    public float oppjumpSpeed;
    public float oppslideSpeed;
    Rigidbody2D rb;
    Animator am;
    int oppjump;
    int oppslide;
    Renderer rend;

    //Use this for initialzation
    void Start()
    {
        oppjump = 0;
        oppslide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(oppJump) && oppjump < 3)
        {
            oppjump++;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            am.SetBool("oppjump", true);
            rb.velocity = new Vector2(rb.velocity.x, oppjumpSpeed);
        }
        else if (Input.GetKey(oppSlide) && oppslide < 1)
        {
            oppslide++;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            am.SetBool("oppslide", true);
            rb.velocity = new Vector2(rb.velocity.x, oppslideSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        oppjump = 0;
        am.SetBool("oppjump", false);

        oppslide = 0;
        am.SetBool("oppslide", false);
    }
}
