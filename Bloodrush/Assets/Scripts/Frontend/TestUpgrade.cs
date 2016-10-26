using UnityEngine;
using System.Collections;

public class TestUpgrade : Upgrade {

    void Start()
    {
        BCAmount = 3;
        BPMAmount = 4;
        cost = 5;
    }

    public void mClick()
    {
        BuyBC();
        BuyBPM();
    }

}
