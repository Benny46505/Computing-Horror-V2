using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Escape Mode
    public GameObject escapetext;
    public GameObject escapetrigger;
    public GameObject escapeMusic;
    bool canEscape;
    #endregion

    #region Find Mode
    public GameObject findtext;
    public GameObject Ambients;
    bool inFindMode;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Find Mode Start
        
        findtext.SetActive(true);
        Ambients.SetActive(true);

        //Escape Mode Start
        escapetext.SetActive(false);
        escapetrigger.SetActive(false);
        escapeMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
            escapetrigger.SetActive(true);
            escapeMusic.SetActive(true);
       }

       if (inFindMode == false)
       {
            findtext.SetActive(false);
            Ambients.SetActive(false);
        }
   
    }
}
