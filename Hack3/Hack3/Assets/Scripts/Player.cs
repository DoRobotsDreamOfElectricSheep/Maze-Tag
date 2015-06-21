using UnityEngine;
using System.Collections;

public class Player : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (photonView.isMine) {
			var pos = transform.position;
			pos += Camera.main.transform.forward * (float)2.0 * Time.deltaTime;
			transform.position = pos;

		//}
	}
}
