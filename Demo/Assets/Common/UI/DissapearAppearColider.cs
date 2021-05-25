using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearAppearColider : MonoBehaviour
{
    
    public float Sequence = 0;
    public GameObject Appear;
    public GameObject DissaAppear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Sequence){
            case(1):{
                Appear.SetActive(true);
                DissaAppear.SetActive(false);}
                break;
            case(2):{
                Appear.SetActive(false);
                }
                break;
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Activator")
        {
            Sequence = 1;
        }
        if (other.tag == "PlayCutScene"){
            Sequence = 2;
        }
    }
}
