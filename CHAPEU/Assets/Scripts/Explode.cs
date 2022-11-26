using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {
	public GameObject Explosion;
	public ParticleSystem[] effects; 

	void OnCollisionEnter2D (Collision2D collision){
		Instantiate (Explosion, transform.position, transform.rotation);
		foreach (var effect in effects) {
			effect.transform.parent = null;
			effect.Stop ();
			Destroy (effect.gameObject, 2.0f);
		}
		Destroy (gameObject);

	}



}
