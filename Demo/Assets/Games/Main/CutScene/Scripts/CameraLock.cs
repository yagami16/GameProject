using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public float speed;
    public Transform door;
    public bool Active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Active = GameObject.Find("FirstPerson-AIO (2)").GetComponent<CutScene>().StartAnim;
        if (Active == true)
        {
            Vector3 direction = door.position-transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation,rotation,speed*Time.deltaTime);
        }
    }
}
