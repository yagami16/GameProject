using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource theMusic;
    public bool playgg;
    public Scroller BS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!playgg)
        {
            if (Input.anyKeyDown)
            {
                playgg = true;

                theMusic.Play();
            }
        }else
        {
            
        }
    }
}
