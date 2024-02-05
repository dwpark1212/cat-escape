using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector1 : MonoBehaviour
{

    [SerializeField]
    private Text scoreText;

    public int score;

    private void Start()
    {
        Debug.LogFormat("scoreText: {0}", scoreText);
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
