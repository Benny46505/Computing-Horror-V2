using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD : MonoBehaviour
{
    public AudioSource pickupsound;

    private void OnTriggerEnter(Collider other)
    {
        pickupsound.Play();
        ScoreSystem.score += 1;
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
