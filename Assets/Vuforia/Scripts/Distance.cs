using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {

	// Use this for initialization
	public float distFromPlayer;
	public Transform hoop;
	public GameObject Gofar;
	public GameObject Ball;







	void Update()
	//	{
	{
//		distance =Vector3.Distance(transform.position, sphere.position);

		distFromPlayer = Vector3.Distance (hoop.position, transform.position);
			
		if (distFromPlayer <= 50) {

			Gofar.SetActive  (true);

			Ball.SetActive (false);

		
			Debug.Log ("GET LOST");

		
		
		}



		else if (distFromPlayer >= 50) {
			
			Gofar.SetActive (false);

			Ball.SetActive  (true);
		

		
		}
	}
}