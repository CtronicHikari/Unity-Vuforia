using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class VirtulButtonCtrl : MonoBehaviour,IVirtualButtonEventHandler
{
    public UnityEvent playEvent, pauseEvent;
    private int count = 0;

    private void Awake()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        count++;
        if (count % 2 == 1) 
        {
            playEvent.Invoke();
        }
        else
        {
            pauseEvent.Invoke();
        }
        print("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        print("Released");
    }
}
