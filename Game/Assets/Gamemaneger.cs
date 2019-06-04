using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using MiniJSON;
using System;
using System.IO;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Gamemaneger : MonoBehaviour
{
    [SerializeField] private ObstacleSpawner obstacleSpawner;
    [SerializeField] private Text currentScore;
    void Start()
    {
        obstacleSpawner.StartSpawn();
        Score.score = 0;
    }
		
    void Update()
    {
        currentScore.text = string.Format("score {0}", Score.score);
    }

    public void AddPoint(int point)
	{

		Score.score += point;
	}
}
