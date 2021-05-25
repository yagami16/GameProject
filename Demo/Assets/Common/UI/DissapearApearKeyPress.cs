using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearApearKeyPress : MonoBehaviour
{
    public GameObject JustTheImg;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            {
                JustTheImg.SetActive(false);
            }
    }
}
