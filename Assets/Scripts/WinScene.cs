using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinScene : MonoBehaviour
{
    public static bool gameBeaten, gameBeaten2, gameBeaten3;

    public GameObject endtime;



    // Start is called before the first frame update
    void Start()
    {
        gameBeaten = true;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(CloseGame());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            Debug.LogWarning("Going Back To Main");
        }
    }

    void BeatenTimes()
    {
        if (gameBeaten == true)
        {
            gameBeaten2 = true;
        }

        if (gameBeaten == true && gameBeaten2 == true)
        {
            gameBeaten3 = true;
        }
    }

    IEnumerator CloseGame()
    {
        yield return new WaitForSeconds(10);
        {
            Application.Quit();
            Debug.LogWarning("Only Works In Builds");
        }
    }
}
