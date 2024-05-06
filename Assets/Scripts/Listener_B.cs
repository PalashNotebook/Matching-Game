using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        ActionClass.SwipeDetection += ListenB;
    }

    void OnTriggerExit()
    {
        ActionClass.SwipeDetection -= ListenB;
    }

    public void ListenB(int a)
    {
        
    }
}
