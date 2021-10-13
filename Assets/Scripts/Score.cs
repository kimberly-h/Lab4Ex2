using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        ScoreNumber.Instance.ScoreIncrease(1);
        #region observer
        clicked?.Invoke();
        #endregion
    }
}