using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float bpm;

    public bool StartG;
    // Start is called before the first frame update
    void Start()
    {
        bpm = bpm / 60f;
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
            transform.position -= new Vector3 (bpm * Time.deltaTime, 0f, 0f);
        }
        
    }
}
