using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIillboard : MonoBehaviour
{
    private Camera playercam;

    public bool useStaticMode;

    // Start is called before the first frame update
    void Start()
    {
        playercam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (!useStaticMode)
        {
            transform.LookAt(playercam.transform);
        }
        else
        {
            transform.rotation = playercam.transform.rotation;
        }

        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }
}
