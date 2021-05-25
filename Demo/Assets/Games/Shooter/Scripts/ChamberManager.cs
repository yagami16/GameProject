using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamberManager : MonoBehaviour
{
    public Animator doorL;
    public Animator doorR;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Open()
    {
        doorL.SetFloat("Operation Nmbr", 1);
        doorR.SetFloat("Operation Nmbr", 1);
    }
}
