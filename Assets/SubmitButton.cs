//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubmitButton : MonoBehaviour
{
    private double Cost;
    // Start is called before the first frame update
    void Start()
    {
        Cost = Random.Range(0, 100);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ValidateSubmission();
    }

    private void ValidateSubmission()
    {
        if(DollarBill.GetAmount() == Cost)
        {
            print("You got it! Congrats!");
        }
    }
}
