using UnityEngine;
using System.Collections;

//[ExecuteInEditMode]
public class TileMaterial : MonoBehaviour {

	public int scaleMod = 6;
	public Vector2 offset = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
		Vector2 newScale = new Vector2 ();
		Vector3 lScale = new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
		if (lScale.x == 1) {
			newScale.x = lScale.z;
			newScale.y = lScale.y;
		}
		else if (lScale.y == 1) {
			newScale.x = lScale.x;
			newScale.y = lScale.z;
		}
		else if (lScale.z == 1) {
			newScale.x = lScale.x;
			newScale.y = lScale.y;
		}

		newScale.x /= (float) scaleMod;
		newScale.y /= (float) scaleMod;

		renderer.material.SetTextureScale("_MainTex", newScale);
		renderer.material.SetTextureScale("_BumpMap", newScale);

		renderer.material.SetTextureOffset("_MainTex", offset);
		renderer.material.SetTextureOffset("_BumpMap", offset);
	}
	
	// Update is called once per frame
	void Update () {
	}
}