using UnityEngine;
using System.Collections;

public class SlowMove : MonoBehaviour {

	public GameObject target;
	public float speed;

	public bool done;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( (target.transform.position - transform.position).magnitude <= speed/Time.deltaTime ){
			Debug.Log ("close, done");
			transform.position = target.transform.position;
			done = true;
		} else{
			if(!done){
				transform.Translate(  speed/Time.deltaTime * (target.transform.position - transform.position).normalized );
			}
		}
	}
}
