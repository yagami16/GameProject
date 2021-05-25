using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerUnload : MonoBehaviour
{
    public AudioSource ScratchSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScratchSound.Play();
        //animator = Canvas.GetComponent<Animator>();
        //animator.SetBool("Lose",true);
        //Canvas.GetComponent<Animator>().Play("Unload");
        StartCoroutine(UNLoad());
    }

    IEnumerator UNLoad(){
        yield return new WaitForSeconds(2f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
