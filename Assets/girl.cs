using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl : MonoBehaviour
{
    [SerializeField] KeyCode Jump;
    [SerializeField] KeyCode Slide;
    public float jumpSpeed;
    Rigidbody2D rb;
    Animator am;
    int jump;

    //Use this for initialzation
    void Start()
    {
        jump = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Jump) && jump < 2)
        {
            jump++;
            am.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        jump = 0;
        am.SetBool("Jump", false);
    }
}
    


