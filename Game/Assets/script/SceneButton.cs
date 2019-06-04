using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour {

	// Use this for initialization
	void Start(){
		SceneManager.activeSceneChanged += OnActiveSceneChanged;
	}
	public void OnClickPlayButton(){
		SceneManager.LoadScene ("Play");
	}
	public void OnClickRankingButton(){
		SceneManager.LoadScene ("Ranking");
		//OnActiveSceneChanged ( Scene "Play", Scene "Ranking" );
	}
	void OnActiveSceneChanged( Scene prevScene, Scene nextScene ){
		Debug.Log (prevScene.name + "->" + nextScene.name);
	}
}
