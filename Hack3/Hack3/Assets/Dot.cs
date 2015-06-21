using UnityEngine;
using System.Collections;

public class Dot :MonoBehaviour {
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "pacman") {
			Destroy(gameObject);

			//collisionInfo.transform.position = new Vector3(4,(float).72,(float)11);

			GameManager.DotCount --;
			if (GameManager.DotCount == 40)
			{
				Application.LoadLevel("hack3");
			}
		}
	}
}
