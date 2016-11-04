using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CALUpgrade : Upgrade {

    public int calMultIncr;
    public int o2PbCost;
    public int o2Cost;

    private Button _upgradeButton;

    private void Start()
    {
        if (!GetComponent<Button>())
        {
            Debug.Log("Make sure this script is attached to a Button!");
            return;
        }
        else
        {
            _upgradeButton = GetComponent<Button>();
        }
    }

    private void Update()
    {
        if (_upgradeButton)
        {
            if (ScoreManager.oxygen < o2Cost || ScoreManager.multiplier < o2PbCost)
                _upgradeButton.interactable = false;
            else
                _upgradeButton.interactable = true;
        }
    }

    public void LevelUp()
    {
        BuyCAL(calMultIncr, o2Cost, o2PbCost);
    }
}
