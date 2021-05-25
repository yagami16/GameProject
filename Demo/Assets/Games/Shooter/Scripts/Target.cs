using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool change = false;
    public Material Material1;
    public GameObject Big;
    public GameObject Small;
    public GameObject Room;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(change == true)
        {
            Big.GetComponent<MeshRenderer>().material = Material1;
            Small.GetComponent<MeshRenderer>().material = Material1;
        }
    }

    public void DoIt(){
        if(change == false)
        {
            Room.GetComponent<RoomManager>().Kill();
        }
        change = true;
    }
}
