using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {

	// Use this for initialization
	public float distFromPlayer;
	public Transform hoop;
	public GameObject Gofar;




	void Update()
	//	{
	{
//		distance =Vector3.Distance(transform.position, sphere.position);

		distFromPlayer = Vector3.Distance (hoop.position, transform.position);
			
		if (distFromPlayer <= 44) {

			Gofar.SetActive  (true);
		
			Debug.Log ("GET LOST");

		
		
		}

		if (distFromPlayer >= 44) {
		
			Gofar.SetActive (false);
		
		}
	}
}