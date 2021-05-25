using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Text text;
    public int num;

    void Update ()
    {
        text.text = num.ToString();
    }
}
