using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int timeLimit;
    public Text timerText;
    float timeLeft;
    public GameObject winCamera;
    public PlayerController player1;
    public PlayerController player2;
    int p1Score = 0;
    int p2Score = 0;
    GameObject winner;
    public Text p1ScoreText;
    public Text p2ScoreText;

    void Start()
    {
        timeLeft = timeLimit;
    }

    public void Score(string player)
    {
        if(player == "left")
        {
            p1Score++;
            p1ScoreText.text = p1Score.ToString();
        }
        else
        {
            p2Score++;
            p2ScoreText.text = p2Score.ToString();
        }
    }


    void FixedUpdate()
    {
        timeLeft -= Time.fixedDeltaTime;
        timerText.text = Mathf.Round(timeLeft).ToString();
        if (Mathf.Round(timeLeft) <= 0 | p1Score == 32 | p2Score == 32)
        {
            if (p1Score > p2Score)
            {
                winner = player1.gameObject;
            }
            else
            {
                winner = player2.gameObject;
            }
            timerText.gameObject.SetActive(false);
            winCamera.GetComponent<winCameraScript>().target = winner.transform;
            winCamera.GetComponent<winCameraScript>().winningSide = winner.transform.name;
            winCamera.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
