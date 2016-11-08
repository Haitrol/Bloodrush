using UnityEngine;
using System.Collections;

public class BeatManager : MonoBehaviour {

    public float beatDelay = 1;

    [HideInInspector]
    public int Beat = 0;

    //implement animator

    //Function for InvokeRepeating
    public void Incr()
    {
        ScoreManager.IncreaseOxygen();
        ScoreManager.IncreaseCalories();
        Beat++;
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
