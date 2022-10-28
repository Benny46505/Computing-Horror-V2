using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Escape Functions
    public GameObject escapetext;
    public GameObject escapetrigger;
    public GameObject escapeMusic;
    bool canEscape;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
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
       }

       if (canEscape == true && ScoreSystem.score == 5)
       {
            escapetext.SetActive(true);
            escapetrigger.SetActive(true);
            escapeMusic.SetActive(true);
       }
   
    }
}
