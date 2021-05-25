using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearTerrain : MonoBehaviour
{
    
    public float Sequence = 0;
    public GameObject Terrain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Sequence){
            case(1):{
                Terrain.SetActive(false);}
                break;
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player")
        {
            Sequence = 1;
        }
    }
}
