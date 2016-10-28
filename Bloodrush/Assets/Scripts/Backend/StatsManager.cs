using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    public Text BPMText;

    BeatManager bm;
    float time = 0;
    float t;

    void Start()
    {
        bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();
    }

    void Update()
    {
        if (bm.beat > 0)
        {
            t += Time.deltaTime;
            
            float avg = Mathf.RoundToInt((bm.beat / (t*60))*1000);

            BPMText.text = avg.ToString() + "\nBPM";
        }
    }
}
