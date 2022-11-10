using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObj : MonoBehaviour
{
    bool inRange = false;

    public GameObject NA, A;

    private void OnTriggerStay(Collider other)
    {
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true && Input.GetKeyDown(KeyCode.E))
        {
            A.SetActive(true);
            NA.SetActive(false);
        }
        else
        {
            A.SetActive(false);
            NA.SetActive(true);
        }
    }
}
