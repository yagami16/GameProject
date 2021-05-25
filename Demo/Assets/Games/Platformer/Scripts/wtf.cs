using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wtf : MonoBehaviour
{
    Transform CamTransform;
    public Transform Player;
    public GameObject Cam1;
 
     void Start()
     {
         CamTransform = Cam1.transform;
     }
     
     void Update () {
 
         CamTransform.position = new Vector3(Player.position.x, Player.position.y+2,  CamTransform.position.z);
     }
}
