using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

    public float speed = 10.0f;

    AudioSource spin;

    void Start()
    {
        spin = GetComponent<AudioSource>();
    }

	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);

        if (speed >= 100.0f)
        {
            if(!spin.isPlaying)
                spin.Play();

            spin.volume = speed/1000;
        }
	}
}
