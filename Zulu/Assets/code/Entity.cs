using UnityEngine;
using System.Collections;

public abstract class Entity : MonoBehaviour {
	public float speed;

	void Start () {
	
	}
	

	void Update () {
	
}
	public void TpToPos (Vector2 pos ){ 
		GetComponent<Rigidbody2D>().transform.position = pos;
	}
}