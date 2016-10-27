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
            
            float avg = bm.beat / (t*60);
            avg *= 100;
            avg = (int)avg;

            BPMText.text = avg.ToString() + "\nBPM";
        }
    }
}
