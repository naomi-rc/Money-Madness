//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubmitButton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print("Button init");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("click");
        ValidateSubmission();
    }

    private void ValidateSubmission()
    {
        if(DollarBill.GetAmount() == MainScript.GetCost())
        {
            print("You got it! Congrats!");
        }
        else
        {
            print("Better luck next time");
        }
    }
}
