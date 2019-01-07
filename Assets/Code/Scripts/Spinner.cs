using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	// Use this for initialization
	public void SpinLeft () {
		transform.Rotate (0, 0, 60 * Time.deltaTime);
	}
	
	// Update is called once per frame
	public void SpinRight () {
		transform.Rotate (0, 0, -60 * Time.deltaTime);
	}
}
