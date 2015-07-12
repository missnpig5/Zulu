using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public int levelWidth;
	public int levelHeight;

	public Transform grassTile;
	public Transform Brick;
	public Transform NewLevel;


	private Color[] tilecolours;

	public Color grassColor;
	public Color BrickColor;
	public Color spawnpointColor;
	public Color Newlevelcolor;

	public Texture2D levelTexture;

	public Entity player;

	void Start () {
		levelWidth = levelTexture.width;
		levelHeight = levelTexture.height;
		loadlevel ();
	
	}
	

	void Update () {
	//	OnTriggerEnter2D();
	}
	public void loadlevel() {
		tilecolours = new Color[levelWidth * levelHeight];
		tilecolours = levelTexture.GetPixels ();

		for (int y = 0; y < levelHeight; y++) {
			for (int x = 0; x < levelWidth; x++) {

				if (tilecolours [x + y * levelWidth] == grassColor) {
					Instantiate (grassTile, new Vector3 (x, y), Quaternion.identity);
				}
				if (tilecolours [x + y * levelWidth] == BrickColor) {
					Instantiate (Brick, new Vector3 (x, y), Quaternion.identity);
				}
				if (tilecolours [x + y * levelWidth] == Newlevelcolor) {
					Instantiate (NewLevel, new Vector3 (x, y), Quaternion.identity);

				}
				if (tilecolours [x + y * levelWidth] == spawnpointColor) {
					Instantiate (grassTile, new Vector3 (x, y), Quaternion.identity);
					Vector2 pos = new Vector2 (x, y);
					player.transform.position = pos;

				}
			}
		}
	}

	/* void OnTriggerEnter2D(Collider2D collisionObject)
	{
		//Debug.Log("Trigger Hit");
		if (collisionObject.gameObject.tag == "h") {
			Application.LoadLevel ("h12");
		}
	
	} */
	}


