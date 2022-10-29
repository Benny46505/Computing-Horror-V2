using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openable : MonoBehaviour
{
    #region sprites
    public GameObject opened, closed;
    #endregion

    #region Hitbox
    public GameObject openedbox, closedbox;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        closed.SetActive(true);
        opened.SetActive(false);

        closedbox.SetActive(true);
        openedbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        closed.SetActive(false);
        opened.SetActive(true);

        //hitboxes

        closedbox.SetActive(false);
        openedbox.SetActive(true);


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        closed.SetActive(true);
        opened.SetActive(false);

        //hitboxes

        closedbox.SetActive(true);
        openedbox.SetActive(false);
    }
}
