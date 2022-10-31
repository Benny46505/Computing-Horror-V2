using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EndlessChaser : MonoBehaviour
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
        if (EndlessModeScore.Escore == 1)
        {
            ai.speed = 1;
        }

        if (EndlessModeScore.Escore == 2)
        {
            ai.speed = 2;
        }

        if (EndlessModeScore.Escore == 3)
        {
            ai.speed = 3;
        }

        if (EndlessModeScore.Escore == 4)
        {
            ai.speed = 4;
        }

        if (EndlessModeScore.Escore == 5)
        {
            ai.speed = 5;
        }

        if (EndlessModeScore.Escore > 7)
        {
            ai.speed = 7;
        }

        if (EndlessModeScore.Escore > 10)
        {
            ai.speed = 9;
        }

        if (EndlessModeScore.Escore > 15)
        {
            ai.speed = 15;
        }


        if (EndlessModeScore.Escore > 20)
        {
            ai.speed = 15;
        }

        if (EndlessModeScore.Escore > 25)
        {
            ai.speed = 19;
        }

        if (EndlessModeScore.Escore > 30)
        {
            ai.speed = 26;
        }


        if (EndlessModeScore.Escore > 100)
        {
            ai.speed = 5003;
        }


        if (ScoreSystem.score > EndlessModeScore.Escore)
        {
            ai.speed = 35;
        }

        if (EndlessModeScore.Escore > 60)
        {
            ai.speed = 46;
        }


        if (ScoreSystem.score > 75)
        {
            ai.speed = 64;
        }

        if (EndlessModeScore.Escore > 91)
        {
            ai.speed = 86;
        }
    }
}
