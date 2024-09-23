using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    public float shrinkFactor = 0.95f;
    void OnCollisionEnter(Collision collision)
    {
        //Shrink object on collision
        transform.localScale *= shrinkFactor;
    }
}
