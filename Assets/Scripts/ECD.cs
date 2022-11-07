using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ECD : MonoBehaviour
{

    int amount = 1;

    public AudioSource pickupsound;

    private void OnTriggerEnter(Collider other)
    {
        pickupsound.Play();
        EndlessModeScore.Escore += amount;
    }


    private void OnTriggerExit(Collider other)
    {
        pickupsound.Play();
        EndlessModeScore.Escore += amount;
    }

    // Update is called once per frame
    void Update()
    {

        //Triggers Method of Checking How Much CD's Are Collected
        Value();
    }

    //Checking How Much CD's Are Collected
    void Value()
    {
        if (EndlessModeScore.Escore == 3)
        {
            amount = 3;
        }

        if (EndlessModeScore.Escore == 6)
        {
            amount = 6;
        }


        if (EndlessModeScore.Escore == 9)
        {
            amount = 9;
        }

        if (EndlessModeScore.Escore == 12)
        {
            amount = 12;
        }
    }

}
