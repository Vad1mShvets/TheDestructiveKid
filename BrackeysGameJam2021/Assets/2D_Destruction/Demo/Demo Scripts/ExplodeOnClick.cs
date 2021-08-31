using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	private Explodable _explodable;

	void Start()
	{
		_explodable = GetComponent<Explodable>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name.Contains("Hammer"))
		{
			_explodable.explode();
			ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
			ef.doExplosion(transform.position);
		}
	}
}
