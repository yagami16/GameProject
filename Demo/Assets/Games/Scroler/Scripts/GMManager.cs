using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool startPlaying;
    public float score;
    public Scroller BS;
    public AudioSource theMusic;
    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying){
            if(Input.anyKeyDown){
                startPlaying=true;
                BS.StartG = true;

                theMusic.Play();
            }
        }
    }

    public void NoteMiss(){
        score = score - 1;
    }
}
