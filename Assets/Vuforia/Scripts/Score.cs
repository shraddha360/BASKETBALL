﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Score : MonoBehaviour {  	public int scoreValue = 1;  	// Use this for initialization 	void Start () {   	}  	void OnTriggerEnter (Collider collision) 	{ 		Debug.Log ("Decrease"); 		if (collision.gameObject.tag == "Ball") {  			ScoreText.score += scoreValue;   		}    	} }  