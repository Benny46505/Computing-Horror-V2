using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Player;

    public Transform s1, s2, s3, s4, s5, s6;

    int spawnint = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnint = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnint == 1)
        {
            Player.transform.position = s1.transform.position;
        }

        if (spawnint == 2)
        {
            Player.transform.position = s2.transform.position;
        }

        if (spawnint == 3)
        {
            Player.transform.position = s3.transform.position;
        }

        if (spawnint == 4)
        {
            Player.transform.position = s4.transform.position;
        }

        if (spawnint == 5)
        {
            Player.transform.position = s5.transform.position;
        }

        if (spawnint == 6)
        {
            Player.transform.position = s6.transform.position;
        }
    }
}
