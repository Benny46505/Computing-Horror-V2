using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ECD : MonoBehaviour
{
    

    //Positions
    public Transform respawn;

    int amount = 1;

    public AudioSource pickupsound;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Starts Delay of Collection
            StartCoroutine(Collection());
        }
    }


    // Update is called once per frame
    void Update()
    {

        //Triggers Method of Checking How Much CD's Are Collected
        Value();
    }

    IEnumerator Collection()
    {
        yield return new WaitForSeconds(0.5f);
        {
            pickupsound.Play();
            EndlessModeScore.Escore += amount;
        }
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
