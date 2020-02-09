using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarBill : MonoBehaviour
{
    private GameObject AmountValue;
    private static double amount;
    // Start is called before the first frame update
    void Start()
    {
        AmountValue = GameObject.Find("AmountValue");
    }

    // Update is called once per frame
    void Update()
    {

    }

  
    private void OnMouseDown()
    {
        var TextMesh = AmountValue.GetComponent("TextMesh");
        switch (name)
        {
            case "DollarBill20": amount += 20; break;
            case "DollarBill10": amount += 10; break;
            case "DollarBill5": amount += 5; break;
            case "DollarBill1": amount += 1; break;
        }
        if (TextMesh != null)
        {
            ((TextMesh)TextMesh).text = "$" + amount;
           
        }

    }

    public static double GetAmount()
    {
        return amount;
    }
}
