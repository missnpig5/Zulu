using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	public bool outsideDoor;
	public house House;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c) {
		Entity e = c.GetComponent<Entity>();
		if(e != null)
		{
			if(outsideDoor)
				House.gotoroom(e);
			else
				House.Leavehouse(e);
		}
		
	}
}
