using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColored : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PJ")
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Blue");
            Destroy(gameObject);
        }
    }
}
