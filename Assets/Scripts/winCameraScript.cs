using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCameraScript : MonoBehaviour {

    public string winningSide;
    public Transform target;
    public float angle;
    public Text winnerText;
    public Text winnerText2;
    public Text winnerText3;
    public Text winnerText4;

    public PlayerController player1;
    public PlayerController player2;
    public GameObject score1;
    public GameObject score2;

	
	void Start () {
        gameObject.transform.LookAt(target);
        gameObject.transform.position = new Vector3(target.position.x,target.position.y+1,target.position.z-2);
        player1.moveSpeed = 0;
        player2.moveSpeed = 0;
        score1.SetActive(false);
        score2.SetActive(false);
        winnerText.text = "The " + winningSide + " team won!";
        winnerText2.text = "The " + winningSide + " team won!";
        winnerText3.text = "The " + winningSide + " team won!";
        winnerText4.text = "The " + winningSide + " team won!";
    }
	
	
	void FixedUpdate () {
        gameObject.transform.LookAt(target);
        gameObject.transform.RotateAround(target.position, new Vector3(0, 1, 0), angle);
		
	}
}
