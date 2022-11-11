using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    public GameObject disabled, active;

    public static bool isOn = false;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && isOn == false)
        {
            EnableDistraction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // unused code lmao
        }

        if (other.CompareTag("Enemy"))
        {
            StartCoroutine(DisableDistraction());
        }
    }


    void EnableDistraction()
    {
        disabled.SetActive(false);
        active.SetActive(true);
        isOn = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        active.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisableDistraction()
    {
        yield return new WaitForSeconds(Random.Range(1, 4));
        disabled.SetActive(true);
        active.SetActive(false);
        isOn = false;
    }
}
