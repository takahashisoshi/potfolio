using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RankingPanel : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private Text number;
	[SerializeField] private Text score;
	[SerializeField] private Text date;

	public void SetNumberText(string text){
		number.text = text;
	}
	public void SetScoreText(string text){
		score.text = text;
	}
	public void SetDateText(string text){
		date.text = text;
	}
}
