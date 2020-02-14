﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowColored : MonoBehaviour
{
    

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Yellow");
            Destroy(gameObject);
        }
    }


}
