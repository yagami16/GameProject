using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerd : MonoBehaviour
{
    public bool startPlaying;
    public float score = 25;
    public Scroller BS;
    public AudioSource theMusic;
    public AudioSource ScratchSound;
    public static GameManagerd instance;
    public GameObject Unload;
    public GameObject del;

    public Text text;

    public bool aPRS;
    public bool sPRS;
    public bool dPRS;

    public GameObject a;
    public GameObject s;
    public GameObject d;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        aPRS =  a.GetComponent<ButtonA>().PRS;
        sPRS =  s.GetComponent<ButtonS>().PRS;
        dPRS =  d.GetComponent<ButtonD>().PRS;

        if (aPRS == true && sPRS == true && dPRS ==true)
        {
            NoteMiss();
        }

        text.text = score.ToString();
        if(!startPlaying){
            if(Input.anyKeyDown){
                startPlaying=true;
                BS.StartG = true;

                theMusic.Play();
            }
        }
        if (score < 1){
            theMusic.Stop();
            ScratchSound.Play();
            Unload.SetActive(true);
            del.SetActive(false);
            StartCoroutine("Reset");

        }

    }

    public void NoteMiss(){
        score = score - 1f;
    }
    IEnumerator Reset() {
        yield return new WaitForSeconds(1.5f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
