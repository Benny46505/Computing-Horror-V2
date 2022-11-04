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
        if (WinScene.gameBeaten == true)
        {
            beatengametag.SetActive(true);
            PlayerPrefs.SetInt("Beaten Once", beatengametag ? 1 : 0);
        }
        else
        {
            beatengametag.SetActive(false);
        }

        if (WinScene.gameBeaten2 == true)
        {
            beatengametag.SetActive(true);
            PlayerPrefs.SetInt("Beaten Once", beatengametag2 ? 1 : 0);
        }
        else
        {
            beatengametag.SetActive(false);
        }

        if (WinScene.gameBeaten3 == true)
        {
            beatengametag.SetActive(true);
            PlayerPrefs.SetInt("Beaten Once", beatengametag3 ? 1 : 0);
        }
        else
        {
            beatengametag.SetActive(false);
        }
    }

    private void Update()
    {
        GameBeaten();
    }

}
