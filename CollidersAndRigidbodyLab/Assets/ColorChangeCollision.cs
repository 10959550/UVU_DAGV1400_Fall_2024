using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.yellow;
    void OnCollisionEnter(Collision collision)
    {
        //Change color on collision
        GetComponent<Renderer>().material.color = newColor;
    }
}
