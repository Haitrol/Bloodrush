using UnityEngine;
using System.Collections;

public class BkFallandRemove : MonoBehaviour {

	public float fallSpeed = 8.0f;
	public float spinSpeed = 250.0f;

	// Use this for initialization
	void Start () {

		transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		transform.Rotate (Vector3.forward, spinSpeed * Time.deltaTime);
	
	}
	
	// Update is called once per frame
	void OnBecameInvisible() {
		Destroy (gameObject);
	
	}
}
