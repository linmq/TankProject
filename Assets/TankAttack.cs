using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour 
{
	public GameObject shellPrefab;
	public KeyCode fireKey = KeyCode.Space;

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
			GameObject.Instantiate (shellPrefab, firePosition.position, firePosition.rotation);
		}
	}
}
