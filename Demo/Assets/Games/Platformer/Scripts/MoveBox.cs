using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public float speed;
    public Transform Player;
    public bool StartG;
    public float ypos;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed/(-100f);
        ypos = Player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!StartG)
        {
            if (Input.anyKeyDown)
            {
                StartG = true;
            }
        }else
        {
            transform.position -= new Vector3 (speed , 0f, 0f);
        }
        
    }
}
