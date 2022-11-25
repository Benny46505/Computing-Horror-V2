using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public GameObject UIPanel;

    public AudioSource CorrectINPUT, WrongINPUT;

    public string input;
    public string GoodPass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input == GoodPass)
        {
            CorrectINPUT.Play();
        }
    }
}
