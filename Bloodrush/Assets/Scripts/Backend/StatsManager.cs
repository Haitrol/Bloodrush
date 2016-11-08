using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    public Text BPMText;

    private BeatManager _bm;
    private float time = 0;
    private float t;

    private void Start()
    {
        _bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();
    }

    private void Update()
    {
        if (_bm.Beat > 0)
        {
            t += Time.deltaTime;
            
            float avg = Mathf.RoundToInt(_bm.Beat / (t*60) * 1000);

            BPMText.text = avg + "\nBPM";
        }
    }
}
