using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public GameObject highscore;

    public GameObject zeroLeft;

    public GameObject tip;

    int randomtip;

    public static bool InNormal;

    public static bool InEndless;

    // Start is called before the first frame update
    void Start()
    {
        zeroLeft.SetActive(false);
        randomtip = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        #region HighScore
        if (InNormal == true)
        {
            highscore.GetComponent<TextMeshProUGUI>().text = "CD's Collected: " + ScoreSystem.score + "/5";
            if (ScoreSystem.score == 5)
            {
                zeroLeft.SetActive(true);
            }
            else
            {
                zeroLeft.SetActive(false);
            }
        }

        if (InEndless == true)
        {
            highscore.GetComponent<TextMeshProUGUI>().text = "Cds: " + EndlessModeScore.Escore;
        }
        #endregion

        Tips();
    }

    void Tips()
    {
        if (randomtip == 1)
        {
            tip.GetComponent<TextMeshProUGUI>().text = "Tip: Try flaking her out, it will slightly confuse her.";
        }
        else if (randomtip == 2)
        {
            tip.GetComponent<TextMeshProUGUI>().text = "Tip: CD's are always the last place you would think!!.";
        }
        else if (randomtip == 3)
        {
            tip.GetComponent<TextMeshProUGUI>().text = "Tip: Keep your distance from a decent distance from her.";
        }
        else if (randomtip == 4)
        {
            tip.GetComponent<TextMeshProUGUI>().text = "Tip: She will always try take the fastest shortcut to you, and is smarter than you think.";
        }

    }
}



