using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    //Ideally let designers define a growth calculation
    //Curve
    //public float growthRate = 1;
        
    public void BuyBPM(float BPMAmount, int CALCost, BeatManager bm)
    {
        bm.TimeBetweenBeats(BPMAmount);
        ScoreManager.DecreaseCalories(CALCost);
    }

    public void BuyBC(int BCAmount, int O2Cost)
    {
        ScoreManager.IncreaseMult(BCAmount);
        ScoreManager.DecreaseOxygen(O2Cost);
    }

    public void BuyCAL(int CALAmount, int O2Cost)
    {
        //todo
    }

}
