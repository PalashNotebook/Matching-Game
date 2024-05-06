using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener_A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ActionClass.SwipeDetection += Listen;
    }

    public void Listen(int a)
    {
        
    }
}
