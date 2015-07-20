using UnityEngine;
using System.Collections;

public class house : MonoBehaviour {
	public Vector2  Roompos;
	public Transform roomSpawnT;
	public Vector2  Leave;

	// Use this for initialization
	void Start () {
		Vector2 tpos = new Vector2 (0, 0);
		tpos.x = transform.position.x;
		tpos.y = transform.position.y -2;
		Leave = tpos;
		Roompos = roomSpawnT.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	 
}
	public void gotoroom(Entity e) {
		e.TpToPos(Roompos);
	}
	public void Leavehouse(Entity e) {
		e.TpToPos(Leave);

	}
}

