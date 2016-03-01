using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour 
{
	public int hp = 100;
	public GameObject tankExplosion;
	public AudioClip tankExplosionAudio;
	public Slider hpSlider;

	private int hpTotal;

	void Start()
	{
		hpTotal = hp;
	}

	void TakeDamage()
	{
		if (hp <= 0)
		{
			return;
		}
		hp -= Random.Range (10, 20);
		hpSlider.value = (float)hp / hpTotal;
		if (hp <= 0)
		{
			AudioSource.PlayClipAtPoint (tankExplosionAudio, Camera.main.gameObject.transform.position);
			GameObject.Instantiate (tankExplosion, transform.position + Vector3.up, transform.rotation);
			GameObject.Destroy (this.gameObject);
		}
	}
}
