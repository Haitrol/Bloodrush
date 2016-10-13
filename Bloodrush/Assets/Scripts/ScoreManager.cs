using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    static int score { get; set; }
    public Text scoreText;

    GUIStyle style;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int scoreAmount)
    {
        score += scoreAmount;
    }

    public void SetScore(int a)
    {
        score = a;
    }

    //void OnGUI()
    //{
    //    style = new GUIStyle();
    //    style.fontSize = 60;
    //    style.normal.textColor = Color.white;
    //    GUILayout.TextArea(score.ToString(), style);
    //}
}
