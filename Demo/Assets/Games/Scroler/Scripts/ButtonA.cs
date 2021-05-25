using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonA : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite PressedImage;
    public bool PRS;
    public static ButtonA instance;
    
    public int _overlaps;

    public KeyCode keyToPress;

    public bool JustOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = PressedImage;
            PRS=true;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
            PRS=false;
        }

        /*if (_overlaps==0 && PRS == true)
        {
            if (JustOnce == false)
            {
                StartCoroutine(Missclick());   
            }
        }*/
    }

    public bool isOverlapping {
        get {
            return _overlaps > 0;
        }
    }

    void OnTriggerEnter(Collider other) {
        _overlaps++;
    }

    public void OnTriggerExit(Collider other) {
        _overlaps--;
    }

    IEnumerator Missclick()
    {
        yield return new WaitForSeconds(0.5f);
        if(PRS == true){
            if (JustOnce == false)
            {
                GameManagerd.instance.NoteMiss();
                GameManagerd.instance.NoteMiss();
                JustOnce = true;
            }
        }
        yield return new WaitForSeconds(0.5f);
        JustOnce = false;
    }

    public void deleted(){
        _overlaps--;
    }
}