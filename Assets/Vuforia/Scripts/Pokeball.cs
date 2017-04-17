
using UnityEngine;
using System.Collections;

public class Pokeball : MonoBehaviour {
	[SerializeField]
	private float throwSpeed = 8500f;
	private float speed;
	private float lastMouseX, lastMouseY;
	public GameObject DefaultPosition;
	public GameObject fake;
	private bool thrown, holding;

	private Rigidbody _rigidbody;
	 Vector3 newPosition;

	void Start() {
		
		_rigidbody = GetComponent<Rigidbody> ();
		newPosition = DefaultPosition.transform.position;

		Reset ();
	}

	void Update() {
		if (holding)
			OnTouch ();

		if (thrown)
			return;

		if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) { //for pc = if(Input.GetButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); //for pc = Input.mousePosition
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100f)) {
				if (hit.transform == transform) {
					holding = true;
					transform.SetParent (null);
				}
			}
		}

		if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended) { //for pc = if(Input.GetButtonUp(0)){
			if (lastMouseY < Input.GetTouch (0).position.y) {
				ThrowBall (Input.GetTouch (0).position);

				fake.SetActive (false);
			}
		}

		if(Input.touchCount == 1) { //for pc = if(Input.GetButton(0)){
			lastMouseX = Input.GetTouch (0).position.x;
			lastMouseY = Input.GetTouch (0).position.y;
		}
	}

	void Reset(){
		CancelInvoke ();

		fake.SetActive (true);
		//transform.position = Camera.main.ViewportToWorldPoint(new Vector3 (0.5f, 0.1f, Camera.main.nearClipPlane * 7.5f));
		transform.position= newPosition;
		thrown = holding = false;

		_rigidbody.useGravity = false;
		_rigidbody.velocity = Vector3.zero;
		_rigidbody.angularVelocity = Vector3.zero;
		transform.rotation = Quaternion.Euler (0f, 200f, 0f);
		//transform.SetParent (Camera.main.transform);
	}

	void OnTouch() {
		Vector3 mousePos = Input.GetTouch (0).position;

		mousePos.z = Camera.main.nearClipPlane * 7.5f;

		newPosition = transform.position;//Camera.main.ScreenToWorldPoint (mousePos);

		transform.localPosition = Vector3.Lerp (transform.localPosition, newPosition, 500f * Time.deltaTime);
	}

	void ThrowBall(Vector3 mousePos) {
		_rigidbody.useGravity = true;

		float differenceY = (mousePos.y - lastMouseY) / Screen.height * 200;
		speed = throwSpeed * differenceY;

		float x = (mousePos.x / Screen.width) - (lastMouseX / Screen.width);
		x = Mathf.Abs (Input.GetTouch (0).position.x - lastMouseX) / Screen.width * 200 * x;

		Vector3 direction = new Vector3 (x, 0f, 1f);
		direction = Camera.main.transform.TransformDirection (direction);

		_rigidbody.AddForce((direction * speed ) + (Vector3.up * speed));

		holding = false;
		thrown = true;

		Invoke ("Reset", 5.0f);
	}
}