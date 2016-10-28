using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int oxygen { get; set; }
    public static int calories { get; set; }
    public static float multiplier { get; set; }
    public static float calMultiplier { get; set; }

    public int oxygenBaseGain = 1;
    public int calorieBaseGain = 1;

    public Text O2Text;
    public Text CALText;

    static int obg;
    static int cbg;

    void Start()
    {
        multiplier = 1;
        calMultiplier = 0;
        obg = oxygenBaseGain;
        cbg = calorieBaseGain;
    }

    void Update()
    {
        O2Text.text = oxygen.ToString();
        CALText.text = calories.ToString();

        //Debug.Log(calMultiplier + " " + cbg);
    }

    static int CalculateO2Amount()
    {
        float calc = oxygen + obg * multiplier;
        return (int)calc;
    }

    static int CalculateCALAmount()
    {
        float calc = calories + cbg * calMultiplier;
        return (int)calc;
    }

    public static void IncreaseOxygen()
    {
        oxygen = CalculateO2Amount();
    }

    public static void DecreaseOxygen(int amount)
    {
        oxygen = oxygen - amount;
    }

    public static void IncreaseCalories()
    {
        calories = CalculateCALAmount();
    }

    public static void DecreaseCalories(int amount)
    {
        calories = calories - amount;
    }

    public static void IncreaseMult(float amount)
    {
        multiplier += amount;
    }
    
    public static void DecreaseMult(float amount)
    {
        multiplier -= amount;
    }

    public static void IncreaseCALMult(float amount)
    {
        calMultiplier += amount;
    }

    public static void DecreaseCALMult(float amount)
    {
        calMultiplier -= amount;
    }
}
