using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CALUpgrade : Upgrade {

    public int CALMultIncr;
    public int o2PBCost;
    public int O2Cost;

    Button upgradeButton;

    void Start()
    {
        if (!GetComponent<Button>())
        {
            Debug.Log("Make sure this script is attached to a Button!");
            return;
        }
        else
        {
            upgradeButton = GetComponent<Button>();
        }
    }

    void Update()
    {
        if (upgradeButton)
        {
            if (ScoreManager.oxygen < O2Cost || ScoreManager.multiplier < o2PBCost)
                upgradeButton.interactable = false;
            else
                upgradeButton.interactable = true;
        }
    }

    public void LevelUp()
    {
        BuyCAL(CALMultIncr, O2Cost, o2PBCost);
    }
}
