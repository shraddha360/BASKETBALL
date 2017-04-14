using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ButtonHandler : MonoBehaviour {

	public GameObject Panel;



	public GameObject Blank;






	// Use this for initialization
	public void Start () {
		
	}
	
	// Update is called once per frame
	public void play () {

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

		Panel.SetActive (true);

	
	}

	public void Can(){


	

	
	
	}
	
	}

