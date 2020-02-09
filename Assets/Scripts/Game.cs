using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static double Cost;
    private static GameObject CostText;
    private static TextMesh CostTextMesh;
    private static TextMesh AmountTextMesh;
    private static GameObject AmountValue;
    private static double Amount;

    void Start()
    {
        CostText = GameObject.Find("CostText");        
        CostTextMesh = (TextMesh)CostText.GetComponent("TextMesh");
        AmountValue = GameObject.Find("AmountValue");
        AmountTextMesh = (TextMesh)AmountValue.GetComponent("TextMesh");
        ResetGame();
        
    }

    public static double GetAmount()
    {
        return Amount;
    }
    public static void SetAmount(double amount)
    {
        if (amount == 0)
        {
            Amount = 0;
            ((TextMesh)AmountTextMesh).text = "$0";
        }
        else
        {
            Amount += amount;
            ((TextMesh)AmountTextMesh).text = "$" + Amount;            
        }
    }
    public static double GetCost()
    {
        return Cost;
    }

    public static void ResetGame()
    {
        Cost = Random.Range(1, 100);
        CostTextMesh.text = "$" + Cost.ToString("F");
        SetAmount(0);
    }
}
