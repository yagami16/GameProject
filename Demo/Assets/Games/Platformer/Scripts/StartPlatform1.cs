using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform1 : MonoBehaviour
{
    public bool StartAnim;
    public float count;
    public Animator platform;
    public Rigidbody character;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartAnim == true)
            {
                 platform.SetBool("Start",true);

            }
    }

    private void OnTriggerEnter(Collider other){   
        StartAnim = true;
        //speed = new Vector3
    }
}
