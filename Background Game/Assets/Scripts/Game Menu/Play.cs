using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("T");
        //GetComponentInParent<Animator>().SetTrigger("PushPlay");
        SceneManager.LoadScene(2);
    }
}
