﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColored : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PLayer")
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Green");
            Destroy(gameObject);
        }
    }
}
