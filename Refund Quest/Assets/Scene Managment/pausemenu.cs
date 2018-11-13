using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {
    public GameObject PauseCanvas;
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PauseCanvas.SetActive(true);
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PauseCanvas.SetActive(false);
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }
    }
    public void Resume()
    {
        //Debug.Log("Resume");
        PauseCanvas.SetActive(false);
        //Cursor.visible = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
