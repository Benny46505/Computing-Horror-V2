using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public GameObject playerView;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerView.GetComponent<Animator>().Play("behind");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerView.GetComponent<Animator>().Play("front");
        }

    }

}
