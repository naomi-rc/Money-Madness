using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubmitButton : MonoBehaviour
{
    private static GameObject GameStatus;
    private static TextMesh GameStatusTextMesh;
    private int TimeDelay = 2;

    void Start()
    {
        GameStatus = GameObject.Find("GameStatus");
        GameStatusTextMesh = (TextMesh)GameStatus.GetComponent("TextMesh");
    }

    private void OnMouseDown()
    {
        ValidateSubmission();
    }

    private void ValidateSubmission()
    {
        if(Game.GetAmount() == Game.GetCost())
        {
            StartCoroutine(ShowMessage("Awesome!", TimeDelay));
        }
        else
        {
            StartCoroutine(ShowMessage("Ooops!", TimeDelay));           
        }

        Game.ResetGame();
    }

    IEnumerator ShowMessage (string message, int timeDelay)
    {
        GameStatusTextMesh.text = message;
        GameStatus.SetActive(true);
        yield return new WaitForSeconds(timeDelay);
        GameStatus.SetActive(false);
    }
}
