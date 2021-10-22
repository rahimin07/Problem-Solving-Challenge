using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    private int score;
    
    public float GetCurrentScore()
    {
    	return score;
    }
    public void IncrementScore()
    {
    	score++;
    }
    public int Score
    {
    	get { return score; }
    }
}
