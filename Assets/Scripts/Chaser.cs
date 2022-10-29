using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public GameObject FindVL, escapeVL;

    public NavMeshAgent ai;
    public Transform player;
    Vector3 dest;

    // Start is called before the first frame update
    void Start()
    {
        escapeVL.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        dest = player.position;
        ai.destination = dest;

        if (ScoreSystem.score == 5)
        {
            phaseEscape();
        }
    }

    void phaseEscape()
    {
        escapeVL.SetActive(true);
        FindVL.SetActive(false);
    }
}
