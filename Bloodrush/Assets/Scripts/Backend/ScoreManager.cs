using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int oxygen { get; set; }
    public static int calories { get; set; }
    public static float multiplier { get; set; }

    public int oxygenBaseGain = 1;
    public int calorieBaseGain = 1;

    public Text scoreText;

    void Start()
    {
        multiplier = 1;
    }

    void Update()
    {
        scoreText.text = oxygen.ToString();
    }

    int CalculateAmount()
    {
        float calc = oxygen + oxygenBaseGain * multiplier;
        return (int)calc;
    }

    public void IncreaseOxygen()
    {
        oxygen = CalculateAmount();
    }

    public void DecreaseOxygen(int amount)
    {
        oxygen = oxygen - amount;
    }

    public void IncreaseMult(float amount)
    {
        multiplier += amount;
    }
    
    public void DecreaseMult(float amount)
    {
        multiplier -= amount;
    }    
}
