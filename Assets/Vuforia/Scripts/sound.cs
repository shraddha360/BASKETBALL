using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	public AudioSource Sound;
	public AudioClip Bounce , dribble;







	// Use this for initialization
	void Start () { 


//
//		AudioSource Sound = GetComponent<AudioSource>();
	
	}


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject) {
			
			Sound.PlayOneShot (Bounce);

			Debug.Log ("bounce");
		}

	}
			void OnTriggerEnter (Collider collision)
			{
				

				if (collision.gameObject.tag == "collider") {

					Sound.PlayOneShot (dribble);

					Debug.Log ("dd");

				}

		}

	}

