using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject LoadingPanel;
    public GameObject MainPanel;

    public GameObject beatengametag, beatengametag2, beatengametag3;

    private void Start()
    {
        beatengametag3.SetActive(false);
        beatengametag2.SetActive(false);
        beatengametag.SetActive(false);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Play(string map)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        LoadingPanel.SetActive(true);
        MainPanel.SetActive(false);
        SceneManager.LoadScene(map);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.LogWarning("Only Works In Build");
    }


    void GameBeaten()
    {
        if (WinScene.progress == 1)
        {
            beatengametag.SetActive(true);
            beatengametag2.SetActive(false);
            beatengametag3.SetActive(false);
        }

        if (WinScene.progress == 2)
        {
            beatengametag.SetActive(true);
            beatengametag2.SetActive(true);
            beatengametag3.SetActive(false);
        }

        if (WinScene.progress == 3)
        {
            beatengametag.SetActive(true);
            beatengametag2.SetActive(true);
            beatengametag3.SetActive(true);
        }

    }

    void GameBeatenSaves()
    {
        if (WinScene.progress == 1)
        {
            PlayerPrefs.SetInt("Progress", WinScene.progress);
            PlayerPrefs.Save();
            Debug.LogWarning("progress was saved to 1");
        }

        if (WinScene.progress == 2)
        {
            PlayerPrefs.SetInt("Progress", WinScene.progress);
            PlayerPrefs.Save();
            Debug.LogWarning("progress was saved to 2");
        }

        if (WinScene.progress == 3)
        {
            PlayerPrefs.SetInt("Progress", WinScene.progress);
            PlayerPrefs.Save();
            Debug.LogWarning("progress was saved to 3");
        }
    }

    private void Update()
    {
        GameBeaten();
        GameBeatenSaves();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WinScene.progress += 1;
            Debug.Log("progress was increased by 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WinScene.progress -= 1;
            Debug.Log("progress was reduced by 1");
        }
    }

}
