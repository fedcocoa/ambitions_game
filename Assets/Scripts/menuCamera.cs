using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCamera : MonoBehaviour
{

    public float speed;

    void FixedUpdate()
    {
        gameObject.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0,1,0), speed);
    }
}
