using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour
{


	public static int score;  



	//	public Transform currentdoor;
	Text text;   


	void Start ()

	{


		text = GetComponent <Text> ();


		score = 0;
	}


	void Update ()
	{
		
		text.text = " " + score;

		
}
}
