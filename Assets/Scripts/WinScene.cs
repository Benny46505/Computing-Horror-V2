using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinScene : MonoBehaviour
{
    public static int progress;

    public GameObject endtime;

    // Start is called before the first frame update
    void Start()
    {
        progress += 1;

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
        if (progress >= 4)
        {
            progress = 3;
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
