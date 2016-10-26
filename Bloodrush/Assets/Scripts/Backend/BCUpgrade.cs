using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BCUpgrade : Upgrade {

    public int multiplierIncrease;
    public int cost;

    Button upgradeButton;

    void Start()
    {
        if (!GetComponent<Button>())
        {
            Debug.Log("Make sure this script is attached to a Button!");
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
            if (ScoreManager.oxygen < cost)
                upgradeButton.interactable = false;
            else
                upgradeButton.interactable = true;
        }
    }

    public void LevelUp()
    {
        BuyBC(multiplierIncrease, cost);
    }
}
