using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	public void OnClickBotton(){
		SceneManager.LoadScene ("Title");
	}

}
