using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner: MonoBehaviour {

	[SerializeField] private GameObject obs;
	[SerializeField] private GameObject wall_Right;
	[SerializeField] private GameObject wall_Left;
	[SerializeField] private GameObject wall_Top;
	[SerializeField] private GameObject wall_Botton;

	private int i;
	public void StartSpawn(){
		StartCoroutine(Spwan());
	}
	
	IEnumerator Spwan(){
		while(true){
			float x = UnityEngine.Random.Range (wall_Left.transform.position.x, wall_Right.transform.position.x);
			float y = UnityEngine.Random.Range (wall_Botton.transform.position.y, wall_Top.transform.position.y);
				float z = UnityEngine.Random.Range (18f, 20f);
				Instantiate (obs, new Vector3 (x, y, z), obs.transform.rotation);
			
			yield return new WaitForSeconds(0.2f);
				
		}

	}
}
