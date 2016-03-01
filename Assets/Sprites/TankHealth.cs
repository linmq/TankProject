using UnityEngine;
using System.Collections;

public class TankHealth : MonoBehaviour 
{
	public int hp = 100;
	public GameObject tankExplosion;
	public AudioClip tankExplosionAudio;

	void TakeDamage()
	{
		if (hp <= 0)
		{
			return;
		}
		hp -= Random.Range (10, 20);
		if (hp <= 0)
		{
			AudioSource.PlayClipAtPoint (tankExplosionAudio, Camera.main.gameObject.transform.position);
			GameObject.Instantiate (tankExplosion, transform.position + Vector3.up, transform.rotation);
			GameObject.Destroy (this.gameObject);
		}
	}
}
