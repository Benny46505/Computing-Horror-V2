using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public GameObject note, uiNote;

    public AudioSource open, close;

    bool inRange = false;
    bool inView = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
        
        if (Input.GetKeyDown(KeyCode.E) && inRange == true)
        {
            inView = true;
            open.Play();
            close.Stop();
            note.SetActive(false);
            uiNote.SetActive(true);
            uiNote.GetComponent<Animator>().Play("view");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        open.Stop();
        close.Play();
        uiNote.GetComponent<Animator>().Play("close");
        note.SetActive(true);

        StartCoroutine(DisableUISprite());
    }


    IEnumerator DisableUISprite()
    {
        yield return new WaitForSeconds(0.5f);
        {
            uiNote.SetActive(false);
            Debug.LogWarning("Only Works In Builds");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        uiNote.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log(inRange);
    }
}
