using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManger : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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
