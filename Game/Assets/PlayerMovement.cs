using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	public float speed = 5;
	public GameObject bullet;
	public GameObject muzzle;
	public GameObject Player;
	public GameObject wall_Left;
	public GameObject wall_Right;
	public GameObject wall_Top;
	public GameObject wall_Bottom;
	public GameObject endText;
	public Rigidbody PlayerRigidbody;

	Vector3 LeftPos;
	Vector3 RightPos;
	Vector3 BottomPos;
	Vector3 TopPos;

	void Start () {
		PlayerRigidbody = Player.GetComponent<Rigidbody> ();
		LeftPos = wall_Left.transform.position;
		RightPos = wall_Right.transform.position;
		BottomPos = wall_Bottom.transform.position;
		TopPos = wall_Top.transform.position;
	}
	void Update () {
		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");

		Vector2 direction = new Vector2(x,y).normalized;

		GetComponent<Rigidbody>().velocity = direction*speed;

		if(Input.GetButtonDown("Fire1")){
			Shot();
		}
		//Player.transform.position = (new Vector3 (Mathf.Clamp (Player.transform.position.x, LeftPos.x, RightPos.x),
			//Mathf.Clamp (Player.transform.position.y, BottomPos.y, TopPos.y), transform.position.z));
		
	}
	 
	 void Shot(){
		 var bulletInstance = GameObject.Instantiate(bullet,muzzle.transform.position,bullet.transform.rotation);
	 }
	void OnCollisionEnter(Collision collision){
		Invoke ("ChangeScene", 2);
		endText.SetActive (true);
		PlayerRigidbody.isKinematic = true;

	}
	void ChangeScene(){
		SceneManager.LoadScene ("Result");
	}
}
