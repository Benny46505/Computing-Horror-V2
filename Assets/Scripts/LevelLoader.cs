using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuLoader()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Going Back To Main");
    }

    public void MapLoader(string map)
    {
        SceneManager.LoadScene(map);
        Debug.Log("Going Back To Main");
    }
}
