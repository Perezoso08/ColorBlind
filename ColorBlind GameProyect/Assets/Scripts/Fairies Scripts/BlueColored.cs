using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColored : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Blue");
            Destroy(gameObject);
        }
    }
}
