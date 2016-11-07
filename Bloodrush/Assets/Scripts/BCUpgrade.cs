using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BCUpgrade : Upgrade {

    public int multiplierIncrease;
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
            _upgradeButton.interactable = ScoreManager.oxygen >= o2Cost;
        }
    }

    public void LevelUp()
    {
        BuyBC(multiplierIncrease, o2Cost);
    }
}
