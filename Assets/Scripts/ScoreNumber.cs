using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    private int _score;
    private Text _text;

    public static ScoreNumber Instance { get; private set;}

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _text.text = _score.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ScoreIncrease(int value)
    {

        _score += value;
        _text.text = _score.ToString();
    }
}