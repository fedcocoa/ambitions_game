using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    Transform playerTranform;
    public string cameraAxis;
    public string leftRightAxis;
    public string upDownAxis;
    public float moveSpeed;
    public float lookSpeed;

	void Start () {
        playerTranform = gameObject.GetComponent<Transform>();
	}

    void FixedUpdate()
    {
        playerTranform.Rotate(new Vector3(0, Input.GetAxis(cameraAxis), 0)*lookSpeed);
        playerTranform.Translate(new Vector3(Input.GetAxis(leftRightAxis), 0, Input.GetAxis(upDownAxis))*moveSpeed);
    }

}
