using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public GameObject flashlight, gamestarter;

    public AudioSource pickup;

    // Start is called before the first frame update
    void Start()
    {
        gamestarter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player"))
        {
            flashlight.SetActive(false);
            pickup.Play();
            gamestarter.SetActive(true);
        }
    }
}
