using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BPMUpgrade : Upgrade {

    public float BPMIncrease;
    public int cost;

    Button upgradeButton;
    BeatManager bm;

    void Start()
    {
        bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();

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
            if (ScoreManager.calories < cost)
                upgradeButton.interactable = false;
            else
                upgradeButton.interactable = true;
        }
    }

    public void LevelUp()
    {
        BuyBPM(BPMIncrease, cost, bm);
    }
}
