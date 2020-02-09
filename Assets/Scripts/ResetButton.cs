using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Game.SetAmount(0);
    }
}
