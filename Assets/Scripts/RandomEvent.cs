using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using TMPro;
using UnityEngine;

public class RandomEvent : MonoBehaviour
{
    float randomNum;

    public float waitTime, activeTime;

    //GameObject Events
    public GameObject doors, sleepmode, hiddenroom, hiddenroomUnlock;

    //text
    public GameObject eventInfo;

    public GameObject Player;

    public bool islooping;

    private void Start()
    {
        islooping = true;
        hiddenroom.SetActive(false);
        hiddenroomUnlock.SetActive(true);
        doors.SetActive(false);
        eventInfo.SetActive(false);
        sleepmode.SetActive(false);

        StartCoroutine(randoEvents());
    }

    IEnumerator randoEvents()
    {
        while (islooping == true)
        {
            yield return new WaitForSeconds(waitTime);
            randomNum = Random.Range(0, 3);
            
            #region Events
            if (randomNum == 0)
            {
                eventInfo.GetComponent<TextMeshProUGUI>().text = "Uh oh, the exit went into lockdown, Try to stay alive while the building resets.";
                Doors();
                Alert();
            }

            if (randomNum == 1)
            {
                eventInfo.GetComponent<TextMeshProUGUI>().text = "Cause of running so much your body is starting to eyes are going weak, this may limit your vision";
                Tired();
                Alert();
            }

            if (randomNum == 2)
            {
                eventInfo.GetComponent<TextMeshProUGUI>().text = "A Hidden Room Has Been Revealed, Due to building break in mode being enabled.";
                Secret();
                Alert();
            }

            if (randomNum == 3)
            {
                //nothing lol
            }
            #endregion

        }
    }
    #region Disables
    IEnumerator DisableDoors()
    {
        yield return new WaitForSeconds(activeTime);
        doors.SetActive(false);
    }

    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(activeTime);
        eventInfo.SetActive(false);
    }

    IEnumerator DisableHiddenRoom()
    {
        yield return new WaitForSeconds(activeTime);
        hiddenroom.SetActive(false);
        hiddenroomUnlock.SetActive(true);
    }

    IEnumerator TiredMode()
    {
        yield return new WaitForSeconds(activeTime);
        sleepmode.SetActive(false);
        Player.GetComponent<SUPERCharacterAIO>().canSprint = true;
    }
    #endregion

    #region EventsMethods

    void Doors()
    {
        doors.SetActive(true);
        eventInfo.SetActive(true);
        Debug.Log("EventTriggered!!");
        StartCoroutine(DisableDoors());
    }

    void Secret()
    {
        hiddenroom.SetActive(true);
        hiddenroomUnlock.SetActive(false);
        eventInfo.SetActive(true);
        Debug.Log("EventTriggered!!");
        StartCoroutine(DisableHiddenRoom());
    }

    void Tired()
    {
        sleepmode.SetActive(true);
        eventInfo.SetActive(true);
        Debug.Log("EventTriggered!!");
        StartCoroutine(TiredMode());
        Player.GetComponent<SUPERCharacterAIO>().canSprint = false;
    }

    void Alert()
    {
        eventInfo.SetActive(true);
        Debug.Log("EventTriggered!!");
        StartCoroutine(DisableText());
    }

    #endregion
}
