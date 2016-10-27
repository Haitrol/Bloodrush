using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    //Ideally let designers define a growth calculation
    //Curve
    //public float growthRate = 1;
        
    public void BuyBPM(float BPMAmount, int CalCost, BeatManager bm)
    {
        bm.TimeBetweenBeats(BPMAmount);
        ScoreManager.DecreaseCalories(CalCost);
    }

    public void BuyBC(int BCAmount, int O2Cost)
    {
        ScoreManager.IncreaseMult(BCAmount);
        ScoreManager.DecreaseOxygen(O2Cost);
    }

    public void BuyCAL(int CalAmount, int O2Cost, int O2pBCost)
    {
        ScoreManager.IncreaseCALMult(CalAmount);
        ScoreManager.DecreaseOxygen(O2Cost);
        ScoreManager.DecreaseMult(O2pBCost);
    }

}
