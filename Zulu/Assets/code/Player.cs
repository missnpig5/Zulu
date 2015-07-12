using UnityEngine;
using System.Collections;

public class Player : Entity {
	public Sprite up;
	public Sprite down;
	public Sprite left;
	public Sprite right;
	public SpriteRenderer sprieperant;

	public int direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.up * speed * Time.deltaTime;
			direction = 1;
		}
		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.down * speed * Time.deltaTime;
			direction = 2;
		}
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.left * speed * Time.deltaTime;
			direction = 3;
		}
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.right * speed * Time.deltaTime;
			direction = 4;
		}
		
		if(direction == 1)
		{
			sprieperant.sprite = up;
		}
		if(direction == 2)
		{

			sprieperant.sprite = down;
		}
		if(direction == 3)
		{
			sprieperant.sprite = left;
		}
		if (direction == 4) {
			sprieperant.sprite = right;
		}


		
	}

}
