using UnityEngine;
using System.Collections;

public class BeatManager : MonoBehaviour {

    public float beatDelay = 1;

    ScoreManager sm;
    //implement animator

    void Start()
    {
        sm = GameObject.FindWithTag("Managers").GetComponent<ScoreManager>();
    }

    void Update()
    {
        Debug.Log(beatDelay);
    }

    public void EnableAuto()
    {
        InvokeRepeating("Incr", 0, beatDelay);
    }

    void Incr()
    {
        sm.IncreaseOxygen();
    }

    public void TimeBetweenBeats(float value)
    {
        CancelInvoke("Incr");

        beatDelay -= value;
        beatDelay = Mathf.Clamp(beatDelay, 0.0001f, 10000);
        
        EnableAuto();
    }

}
