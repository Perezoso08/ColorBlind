using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowColored : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PJ")
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Yellow");
            //animator.Play("Colored Yellow");
            Destroy(gameObject);
        }
    }
}
