using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallConrroller : MonoBehaviour {

	private float visiblePosZ = -6.5f;
	private int score = 0;
	private GameObject gameoverText;
	private GameObject scoreText;

	private int smallStarScore = 1;
	private int smallCloudScore = 3;
	private int largeStarScore = 5;
	private int largeCloudScore = 10;


	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find ("GameOverText");
		this.scoreText = GameObject.Find ("ScoreText");
		this.scoreText.GetComponent<Text> ().text = "Score:" + score;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ) {
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "SmallStarTag") {
			this.score += smallStarScore;
		} else if(other.gameObject.tag == "SmallCloudTag"){
			this.score += smallCloudScore;
		} else if(other.gameObject.tag == "LargeStarTag"){
			this.score += largeStarScore;
		} else if(other.gameObject.tag == "LargeCloudTag"){
			this.score += largeCloudScore;
		}
		this.scoreText.GetComponent<Text> ().text = "Score:" + score;
	}
}
