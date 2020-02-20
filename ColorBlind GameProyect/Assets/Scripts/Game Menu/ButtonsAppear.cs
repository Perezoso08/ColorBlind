using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsAppear : MonoBehaviour
{
    public void ExecuteAnimation()
    {
        GetComponent<Animator>().SetTrigger("Push");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

