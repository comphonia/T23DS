using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

    public Text scoreText;
    private int Score = 0;

	// Use this for initialization
	void Start () {
	
	}
    void Update()
    {
        scoreText.text = "" + Score;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            Score++;
        }
    }

    // Update is called once per frame
 
}
