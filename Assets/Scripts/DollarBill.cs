using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarBill : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   /* void Update()
    {

    }
    */
  
    private void OnMouseDown()
    {        
        switch (name)
        {
            case "DollarBill20": Game.SetAmount(20); break;
            case "DollarBill10": Game.SetAmount(10); break;
            case "DollarBill5": Game.SetAmount(5); break;
            case "DollarBill1": Game.SetAmount(1); break;
        }
        

    }

    
}
