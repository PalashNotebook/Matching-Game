using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionClass : MonoBehaviour
{
    public static System.Action<int> SwipeDetection = delegate {  };
    
    // Start is called before the first frame update
    void Start()
    {
        int a = 5;

        if (a > 5)
        {
            SwipeDetection(6);
           
        }
        else if (a < 5)
            SwipeDetection(4);
        else
            SwipeDetection(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
