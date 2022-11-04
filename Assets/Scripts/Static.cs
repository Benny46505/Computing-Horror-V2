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
        HighScore.InNormal = false;
        HighScore.InEndless = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Comma))
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
