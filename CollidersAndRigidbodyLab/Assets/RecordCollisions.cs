using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordCollisions : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " collided with " + collision.gameObject.name);
    }
}
