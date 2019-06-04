using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public int speed = 10;
	public float Maxtime = 3f;
	[SerializeField] private ParticleSystem bamg;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.up.normalized*speed;
		Destroy (gameObject, Maxtime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "obs") {
			FindObjectOfType<Gamemaneger> ().AddPoint (10);
		}

		Destroy(gameObject);
	}

	
}
