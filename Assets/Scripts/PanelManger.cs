using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManger : MonoBehaviour
{
    public GameObject Panel;

    public KeyCode openPanelButton;

    public KeyCode closePanelButton;


    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(openPanelButton))
        {
            openPanel();
        }

        if (Input.GetKeyDown(closePanelButton))
        {
            closePanel();
        }
    }

    public void openPanel()
    {
        
        Panel.SetActive(true);
    }

    public void closePanel()
    {
        Panel.SetActive(false);
    }
}
