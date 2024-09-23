using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        //Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var y = Mathf.PingPong(Time.time, 6);
        var p = new Vector3(x, y, 0);
        transform.position = p;
        
        //Rotate the target GameObject
        transform.Rotate(new Vector3(15, 30, 10) * Time.deltaTime);
    }
}
