using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreControl : MonoBehaviour
{
    public Text score;
	public ScoreControl scoreControl;
	void Start()
	{

	}
	void Update()
	{
		score.text = scoreControl.GetCurrentScore().ToString();
	}
}
