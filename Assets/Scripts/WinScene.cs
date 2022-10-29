using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinScene : MonoBehaviour
{
    public static bool gameBeaten;

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

    IEnumerator CloseGame()
    {
        yield return new WaitForSeconds(6);
        {
            Application.Quit();
            Debug.LogWarning("Only Works In Builds");
        }
    }
}
