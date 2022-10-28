using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoretext;

    public static int score;

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<TextMeshProUGUI>().text = "CD's Collected: " + score + "/5";
    }
}
