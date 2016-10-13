using UnityEngine;
using System.Collections;

public class BloodRain : MonoBehaviour 
{
	public GameObject prefab;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 10; i++)
			Instantiate (prefab, new Vector3 (i * 2.0f, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
