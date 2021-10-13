using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNumber : MonoBehaviour
{
    private int _health = 100;
    private Text _text;

    public static HealthNumber Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _text.text = _health.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoseHP(int value)
    {
        if (_health > 0)
        {
            _health -= value;
            _text.text = _health.ToString();
        }
    }
}