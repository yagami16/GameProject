using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float Enemies;
    public float Eliminations = 0;
    public GameObject Chamber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemies == Eliminations)
        {
            Chamber.GetComponent<ChamberManager>().Open();
        }
    }

    public void Kill()
    {
        Eliminations = Eliminations +1;
    }
}
