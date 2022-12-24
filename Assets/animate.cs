using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{
    private Animator anim;
    float jetpackSpeed = 0f;
    bool isJetpack = false;

    void Start()
    {
        jetpackSpeed = movement.speed * 1.5f;
        anim = GetComponent<Animator>();
        Debug.Log(jetpackSpeed);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isJetpack = true;
        }
        if (isJetpack)
        {
            anim.SetBool("isJetpack", true);
            movement.speed = jetpackSpeed;
        }
        else
        {
            anim.SetBool("isJetpack", false);
        }
    }
}
