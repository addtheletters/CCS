using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	public float rate = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, rate, 0));
	}
}
