using UnityEngine;
using System.Collections;

public class BeatManager : MonoBehaviour {

    public float beatDelay = 1;

    [HideInInspector]
    public int beat = 0;

    //implement animator

    //Function for InvokeRepeating
    void Incr()
    {
        ScoreManager.IncreaseOxygen();
        ScoreManager.IncreaseCalories();
        beat++;
    }

    //Decreases the time between beats by a specified amount
    public void TimeBetweenBeats(float value)
    {
        if(IsInvoking("Incr"))
            CancelInvoke("Incr");

        beatDelay -= value;
        beatDelay = Mathf.Clamp(beatDelay, 0.0001f, 10000);

        InvokeRepeating("Incr", 0, beatDelay);
    }

}
