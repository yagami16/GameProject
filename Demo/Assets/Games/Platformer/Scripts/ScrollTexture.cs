using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public float Xscrl = 5f;
    public float Yscrl = 5f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * Xscrl;
        float OffsetY = Time.time *Yscrl;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (OffsetX, OffsetY);
    }
}
