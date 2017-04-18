using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ButtonHandler : MonoBehaviour {





	public GameObject Panel;

	public  bool Menu= true;

	public GameObject Blank;







	// Use this for initialization




	public void play () {
		



		StartCoroutine (Menufalse ());
		Panel.SetActive (false);


		
	}

	public void quit(){
	Blank.SetActive (true);


		Panel.SetActive (false);


	

	}

	public void yes(){
	
		Application.Quit ();
	
	}

	public void no(){
	
		Panel.SetActive (true);
		Blank.SetActive (false);



	
	}



		public void back(){
		
		StartCoroutine (Menutrue ());
		Panel.SetActive (true);

	
	}

	IEnumerator Menutrue(){
	
		yield return new WaitForSeconds (2f);

		Menu = true;
	
	}
	IEnumerator Menufalse(){

		yield return new WaitForSeconds (2f);

		Menu = false;

	}




	}

