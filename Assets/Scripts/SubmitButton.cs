//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubmitButton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    private void OnMouseDown()
    {
        ValidateSubmission();
    }

    private void ValidateSubmission()
    {
        if(Game.GetAmount() == Game.GetCost())
        {
            print("You got it! Congrats!");
        }
        else
        {
            print("Better luck next time");
        }

        Game.ResetGame();
    }
}
