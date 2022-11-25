using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    [Header("Basic")]
    public UnityEvent Unlock;

    public UnityEvent Locked;

    [Header("Trigger Events")]
    public UnityEvent TriggerEnteredButton;
    public UnityEvent TriggerEnter;

    public UnityEvent TriggerExited;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            TriggerEnteredButton.Invoke();
        }
    
        TriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExited.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation()
    {

    }
}
