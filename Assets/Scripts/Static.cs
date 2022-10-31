using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreSystem.score = 0;
        EndlessModeScore.Escore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ScoreSystem.score = 0;
            EndlessModeScore.Escore = 0;
        }
    }

    void ResetValues()
    {
        ScoreSystem.score = 0;
        EndlessModeScore.Escore = 0;
    }


}
