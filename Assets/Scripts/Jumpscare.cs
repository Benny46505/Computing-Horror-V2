using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public float waitTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameOver());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(waitTime);
        {
            SceneManager.LoadScene("GameOver");
            Debug.LogWarning("You Died");
        }
    }
}
