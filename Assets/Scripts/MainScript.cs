using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    private static double Cost;
    private GameObject CostText;

    // Start is called before the first frame update
    void Start()
    {
        CostText = GameObject.Find("CostText");
        Cost = Random.Range(0, 100);
        TextMesh CostTextMesh = (TextMesh)CostText.GetComponent("TextMesh");
        CostTextMesh.text = "$" + Cost.ToString("F");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static double GetCost()
    {
        return Cost;
    }
}
