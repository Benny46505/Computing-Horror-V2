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

        speedphases();
    }

    void phaseEscape()
    {
        escapeVL.SetActive(true);
        FindVL.SetActive(false);
    }

    void speedphases()
    {
        if (ScoreSystem.score == 1)
        {
            ai.speed = 1;
        }

        if (ScoreSystem.score == 2)
        {
            ai.speed = 2;
        }

        if (ScoreSystem.score == 3)
        {
            ai.speed = 3;
        }

        if (ScoreSystem.score == 4)
        {
            ai.speed = 4;
        }

        if (ScoreSystem.score == 5)
        {
            ai.speed = 5;
        }
    }
}
