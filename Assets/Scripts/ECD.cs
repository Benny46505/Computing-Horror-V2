using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECD : MonoBehaviour
{
    [SerializeField] GameObject self;

    float regenTime = 0;

    float finishRegen = 10;

    bool isDeactived;

    public AudioSource pickupsound;

    private void OnTriggerEnter(Collider other)
    {
        pickupsound.Play();
        EndlessModeScore.Escore += 1;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDeactived)
        {
            
            self.GetComponent<BoxCollider>().enabled = false;
        }
        else if (!isDeactived)
        {
            self.GetComponent<BoxCollider>().enabled = true;
        }

        if (isDeactived)
        {
            regenTime += 1 * Time.deltaTime;
            if (regenTime >= finishRegen)
            {
                isDeactived = false;
                regenTime = 0;
            }
        }
    }

}
