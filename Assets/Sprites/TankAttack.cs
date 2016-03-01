using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour 
{
	public GameObject shellPrefab;
	public KeyCode fireKey = KeyCode.Space;
	public float shellSpeed = 15f;
	public AudioClip shotAudio;

	private Transform firePosition;

	// Use this for initialization
	void Start () 
	{
		firePosition = transform.Find ("FirePosition");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (fireKey)) 
		{
			AudioSource.PlayClipAtPoint (shotAudio, Camera.main.gameObject.transform.position);
			GameObject go = GameObject.Instantiate (shellPrefab, firePosition.position, firePosition.rotation) as GameObject;
			go.GetComponent<Rigidbody> ().velocity = go.transform.forward * shellSpeed;
		}
	}
}
