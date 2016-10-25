using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    ScoreManager sm;
    BeatManager bm;

    public int cost;
    public int BPMAmount;
    public int BCAmount;
    public int CALAmount;

    //Curve
    //public float growthRate = 1;

    void Start()
    {
        GameObject managerObj = GameObject.FindGameObjectWithTag("Managers");
        sm = managerObj.GetComponent<ScoreManager>();
        bm = managerObj.GetComponent<BeatManager>();
    }
    
    public void BuyBPM()
    {
        bm.TimeBetweenBeats(BPMAmount);
        sm.DecreaseOxygen(cost);
    }

    public void BuyBC()
    {
        sm.IncreaseMult(BCAmount);
        sm.DecreaseOxygen(cost);
    }

    public void BuyCAL()
    {
        //todo
    }

}
