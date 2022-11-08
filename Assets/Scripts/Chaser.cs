using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Collider Insigh

    public GameObject FindVL, escapeVL;

    public NavMeshAgent ai;

    public Transform player;
    Vector3 dest;

    float speed = 3.5f, defaultSpeed;

    private void OnTriggerExit(Collider other)
    {
        speed -= 2;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = defaultSpeed;
    }

    private void OnTriggerStay(Collider other)
    {
        speed = defaultSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        escapeVL.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ai.speed = speed;

        dest = player.position;
        ai.destination = dest;
        if (ScoreSystem.score == 5)
        {
            phaseEscape();
        }
        speedphases();

    }

    #region Extras Methods

    void phaseEscape()
    {
        escapeVL.SetActive(true);
        FindVL.SetActive(false);
    }

    void speedphases()
    {
        if (ScoreSystem.score == 1)
        {
            defaultSpeed = 2;
        }

        if (ScoreSystem.score == 2)
        {
            defaultSpeed = 4;
        }

        if (ScoreSystem.score == 3)
        {
            defaultSpeed = 6;
        }

        if (ScoreSystem.score == 4)
        {
            defaultSpeed = 8;
        }

        if (ScoreSystem.score == 5)
        {
            defaultSpeed = 5;
        }
    }

    void Waiting()
    {
        
    }

    #endregion
}
