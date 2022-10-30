using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Escape Mode
    public GameObject escapetext;
    public GameObject escapeMusic;
    public GameObject scarylighting;
    bool canEscape;
    #endregion

    #region Find Mode
    public GameObject findtext;
    public GameObject Ambients;
    bool inFindMode;
    #endregion

    #region General / Extras
    public TextMeshProUGUI timer;
    public GameObject exitdoorC, exitdoorO;
    #endregion


    #region Menus
    public GameObject pausePanel;
    public GameObject gameplayPanel;
    bool isPaused;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //Extras
        pausePanel.SetActive(false);

        //Find Mode Start
        findtext.SetActive(true);
        Ambients.SetActive(true);

        //Escape Mode Start
        escapetext.SetActive(false);
        escapeMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       timer.text = "Time: " + Time.fixedTime;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused == true)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            gameplayPanel.SetActive(false);
        }


        if (isPaused == false)
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            gameplayPanel.SetActive(true);
        }

        if (ScoreSystem.score == 5)
        {
            canEscape = true;
            inFindMode = false;
        }

        if (ScoreSystem.score < 5)
        {
            canEscape = false;
            inFindMode = true;
        }

       if (canEscape == true && ScoreSystem.score == 5)
       {
            escapetext.SetActive(true);
            escapeMusic.SetActive(true);
            scarylighting.SetActive(true);

            //exit doors open
            exitdoorO.SetActive(true);
            exitdoorC.SetActive(false);
        }

       if (inFindMode == false)
       {
            findtext.SetActive(false);
            Ambients.SetActive(false);
        }
   
    }
}
