﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class redbot : MonoBehaviour
{
    [SerializeField] KeyCode RedbotJump;
    [SerializeField] KeyCode RedbotSlide;
    public float redbotjumpSpeed;
    public float redbotslideSpeed;
    Rigidbody2D rb;
    Animator am;
    int redbotjump;
    int redbotslide;

    //Use this for initialzation
    void Start()
    {
        redbotjump = 0;
        redbotslide = 0;
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(RedbotJump) && redbotjump < 2)
        {
            redbotjump++;
            am.SetBool("redbotjump", true);
            rb.velocity = new Vector2(rb.velocity.x, redbotjumpSpeed);
        }
        else if (Input.GetKey(RedbotSlide) && redbotslide < 1)
        {
            redbotslide++;
            
            am.SetBool("redbotslide", true);
            rb.velocity = new Vector2(rb.velocity.x, redbotslideSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
       redbotjump = 0;
       am.SetBool("redbotjump", false);

        redbotslide = 0;
        am.SetBool("redbotslide", false);
    }
}
