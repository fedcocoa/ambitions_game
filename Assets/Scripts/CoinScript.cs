using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    bool used = false;
    GameManager gameManager;

	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}

	void FixedUpdate ()
    {
        gameObject.transform.Rotate(new Vector3(1,1,1));
    }


    void OnCollisionEnter(Collision col)
    {
        if(!used)
        {
            gameManager.Score(col.transform.name);
            used = true;
            col.gameObject.GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
        }
        
    }

}
