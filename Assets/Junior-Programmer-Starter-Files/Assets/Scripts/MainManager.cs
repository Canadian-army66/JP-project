using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static MainManager Instance;
    public Color TeamColor;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
        MainManager.Instance.TeamColor = color;
    }
    private void Start()
    {
        if (MainManager.Instance != null)
        {
            SetColor(MainManager.Instance.TeamColor);
        }
    }

    private void SetColor(Color teamColor)
    {
        throw new NotImplementedException();
    }
}
