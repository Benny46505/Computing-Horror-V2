using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndlessModeScore : MonoBehaviour
{
    public GameObject scoretext;

    public static int Escore;

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<TextMeshProUGUI>().text = "CD's Collected: " + Escore + "/???";
    }
}
