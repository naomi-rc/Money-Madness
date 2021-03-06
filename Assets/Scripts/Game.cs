﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static double Cost;
    private static GameObject CostText;
    private static TextMesh CostTextMesh;
    private static TextMesh AmountTextMesh;
    private static GameObject GameStatus;
    private static TextMesh GameStatusTextMesh;
    private static GameObject AmountValue;
    private static GameObject MainCamera;
    private static double Amount;
    private int TimeDelay = 2;
    public static AudioSource MoneyAudio;
    public static AudioSource CashCorrectAudio;
    public static AudioSource CashIncorrectAudio;
 
   

    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        CostText = GameObject.Find("CostText");        
        CostTextMesh = (TextMesh)CostText.GetComponent("TextMesh");
        AmountValue = GameObject.Find("AmountValue");
        AmountTextMesh = (TextMesh)AmountValue.GetComponent("TextMesh");
        GameStatus = GameObject.Find("GameStatus");
        GameStatusTextMesh = (TextMesh)GameStatus.GetComponent("TextMesh");

        MoneyAudio = MainCamera.AddComponent<AudioSource>();
        MoneyAudio.clip = Resources.Load("Audio/MoneyAudio") as AudioClip;
        CashCorrectAudio = MainCamera.AddComponent<AudioSource>();
        CashCorrectAudio.clip = Resources.Load("Audio/CashCorrect") as AudioClip;
        CashIncorrectAudio = MainCamera.AddComponent<AudioSource>();
        CashIncorrectAudio.clip = Resources.Load("Audio/CashIncorrect") as AudioClip;

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
            MoneyAudio.Play();
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

    public void EnterAmount()
    {
        if (Game.GetAmount() == Game.GetCost())
        {
            StartCoroutine(ShowMessage("Awesome!", TimeDelay));
            CashCorrectAudio.Play();
        }
        else
        {
            StartCoroutine(ShowMessage("Ooops!", TimeDelay));
            CashIncorrectAudio.Play();
        }

        Game.ResetGame();
    }

    IEnumerator ShowMessage(string message, int timeDelay)
    {
        GameStatusTextMesh.text = message;
        GameStatus.SetActive(true);
        yield return new WaitForSeconds(timeDelay);
        GameStatus.SetActive(false);
    }

    public void ResetAmount()
    {
        SetAmount(0);
    }
}
