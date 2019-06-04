using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour {
	public GameObject obss;
	public GameObject field;
	public int speed = 5;
	public GameObject wall_Left;
	public GameObject wall_Right;
	public GameObject wall_Top;
	public GameObject wall_Bottom;
	public GameObject start_wall;
	public float Maxtime = 3f;

	
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.forward.normalized * speed;
		Destroy (gameObject, Maxtime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		float x = Random.Range (-7.74f, 6.89f);
		float y = Random.Range (-8.09f, 7.88f);
		float z = 20f;
		//var hit = collision.gameObject;
		//var health = hit.GetComponent<PlayerHP>();
		//if (health  != null)
		//{
			//health.TakeDamage(40);
		//}
		//Destroy(gameObject);
		//Instantiate (obss, new Vector3(x, y, z), obss.transform.rotation);
		
		Destroy(gameObject);
	}
	
}
