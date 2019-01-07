using UnityEngine;
using System.Collections.Generic;

public class LearningScript : MonoBehaviour {

	public GameObject capsuleGO;
	public Spinner cubeComp;
	// Use this for initialization
	void Start () {
		capsuleGO = GameObject.Find ("Capsule");
		Debug.Log (capsuleGO);
		cubeComp = GameObject.Find ("Cube").GetComponent<Spinner> ();
		Debug.Log (cubeComp);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
						capsuleGO.GetComponent<Spinner> ().SpinLeft ();
				}
		if (Input.GetKey (KeyCode.RightArrow)) {
						capsuleGO.GetComponent<Spinner> ().SpinRight ();
				}
		if (Input.GetKey (KeyCode.UpArrow)) {
						cubeComp.SpinLeft ();
				}
		if (Input.GetKey (KeyCode.DownArrow)) {
						cubeComp.SpinRight ();
				}
	}
}
