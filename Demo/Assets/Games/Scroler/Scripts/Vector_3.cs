using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_3 : MonoBehaviour
{
    public KeyCode keyToPress;
    public static bool PRS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(keyToPress))
        {
            PRS=true;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            PRS=false;
        }

        
    }
}
