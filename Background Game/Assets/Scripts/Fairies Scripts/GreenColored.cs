using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColored : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Animator animator = GetComponentInParent<Animator>();
            animator.SetTrigger("Green");
            Destroy(gameObject);
        }
    }
}
