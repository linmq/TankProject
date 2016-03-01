using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour 
{
	public Transform play1;
	public Transform play2;

	private Vector3 offset;
	private Camera camera;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - (play1.position + play2.position) / 2;
		camera = this.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = (play1.position + play2.position) / 2 + offset;
		float distance = Vector3.Distance (play1.position, play2.position);
		float size = distance * 0.58f;
		camera.orthographicSize = size;
	}
}
