using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos += Camera.main.transform.forward * (float)2.0 * Time.deltaTime;
		pos.y = 0;
		transform.position = pos;
	}
}
