using UnityEngine;
using System.Collections;

public class PulseLightScript : MonoBehaviour
{
    public float pulseDistance = 2;
    public float pulseSpeed = 10;

    Light light;

    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        light.intensity = Mathf.Sin(Time.time * pulseSpeed) * pulseDistance;
    }
}
