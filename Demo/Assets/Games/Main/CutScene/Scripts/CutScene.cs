using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public bool StartAnim;
    public float count;
    public Animator door0;
    public Animator door1;
    public Rigidbody character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartAnim == true)
            {
                door0.SetBool("OpenDisBitch",true);
                door1.SetBool("OpenDisBitch",true);
                 GetComponent<FirstPersonAIO>().enabled = false;
                 character.velocity = Vector3.zero;
                 StartCoroutine(StartMove());
            }
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "PlayCutScene")
        {   
            StartAnim = true;
        }
    }

    IEnumerator StartMove()
    {
	    yield return new WaitForSeconds(6);
    	transform.position -= new Vector3 (0f, 0f, -0.005f);
    }
}
