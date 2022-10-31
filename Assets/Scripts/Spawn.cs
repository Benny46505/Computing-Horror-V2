using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Obj;

    public Transform s1, s2;

    int spawnint = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnint = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnint == 1)
        {
            Obj.transform.position = s1.transform.position;
        }

        if (spawnint == 2)
        {
            Obj.transform.position = s2.transform.position;
        }

       
    }
}
