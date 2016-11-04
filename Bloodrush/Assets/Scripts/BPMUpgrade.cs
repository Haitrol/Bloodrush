using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BPMUpgrade : Upgrade {

    public float BPMIncrease;
    public int CALCost;

    private Button _upgradeButton;
    private BeatManager _bm;

    private void Start()
    {
        _bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();

        if (!GetComponent<Button>())
        {
            Debug.Log("Make sure this script is attached to a Button!");
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
            _upgradeButton.interactable = ScoreManager.calories >= CALCost;
        }
    }

    public void LevelUp()
    {
        BuyBPM(BPMIncrease, CALCost, _bm);
    }
}
