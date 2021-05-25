using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public Text text;
    public int TimeLeft;
    public bool sub = false;
    public bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown){
            start = true;
        }
        if (TimeLeft>0 && sub == false && start == true){
            StartCoroutine(Timerg());
        }
    }
    
    IEnumerator Timerg(){
        sub = true;
        yield return new WaitForSeconds(1);
        text.text = TimeLeft.ToString();
        TimeLeft = TimeLeft - 1;
        sub = false;
    }
}
