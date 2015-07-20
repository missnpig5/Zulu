using UnityEngine;
using System.Collections;

public class Attack : Entity {


	public Entity attack;

	public float distance;
	public float attackDistance;

	void Start () {
	
	}

	void Update () {
		//get the distance from self to target
		float dist = Vector2.Distance(transform.position, attack.transform.position);
		//if we are between distance and attackDistance
		if (dist <= distance && dist > attackDistance) {
			//calculate a new position
			Vector2 newPos = Vector2.MoveTowards (transform.position, attack.transform.position, speed * Time.deltaTime);
			//set to transform
			transform.position = new Vector3 (newPos.x, newPos.y, 0f);
		}
		}
	}
