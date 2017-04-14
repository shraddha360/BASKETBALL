using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	public AudioSource Bounce;





	// Use this for initialization
	void Start () { 


		Bounce= GameObject.FindObjectOfType<AudioSource>();
	

	}



	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ball")
		{
			Bounce.Play();
			Debug.Log("Nurrrr");
		}
		
	}



}
