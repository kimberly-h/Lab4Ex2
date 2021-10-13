using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        HealthNumber.Instance.LoseHP(10);
        #region observer
        clicked?.Invoke();
        #endregion
    }
}