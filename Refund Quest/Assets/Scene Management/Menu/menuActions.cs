using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuActions : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Test");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
