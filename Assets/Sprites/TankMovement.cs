﻿using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
	public float angularSpeed = 10f;
	public float number = 1;
	public AudioClip idleAudio;
	public AudioClip drivingAudio;

	private AudioSource audio;
    private Rigidbody rigidbody;


	// Use this for initialization
	void Start ()
    {
        rigidbody = this.GetComponent<Rigidbody>();
		audio = this.GetComponent<AudioSource> ();
	}

    void FixedUpdate()
    {
		float v = Input.GetAxis("VerticalPlayer" + number);
		rigidbody.velocity = transform.forward * v * speed;
        
		float h = Input.GetAxis ("HorizontalPlayer" + number);
		rigidbody.angularVelocity = transform.up * h * angularSpeed;

		if (Mathf.Abs (h) > 0.1 || Mathf.Abs (v) > 0.1)
		{
			audio.clip = drivingAudio;
			if(audio.isPlaying == false)
				audio.Play ();
		}
		else
		{
			audio.clip = idleAudio;
			if(audio.isPlaying == false)
				audio.Play ();
		}
    }

}
