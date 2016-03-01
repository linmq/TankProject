using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
	public float angularSpeed = 10f;
	public float number = 1;

    private Rigidbody rigidbody;


	// Use this for initialization
	void Start ()
    {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void FixedUpdate()
    {
		float v = Input.GetAxis("VerticalPlayer" + number);
		rigidbody.velocity = transform.forward * v * speed;
        
		float h = Input.GetAxis ("HorizontalPlayer" + number);
		rigidbody.angularVelocity = transform.up * h * angularSpeed;
    }
}
