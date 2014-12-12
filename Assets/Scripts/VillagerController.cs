using UnityEngine;
using System.Collections;
using System.Runtime;

public class VillagerController : MonoBehaviour {

	public int[] stats = {0, 0, 0, 0, 0, 0};
	public Color color;


	public void Init(){

		color = new Color(Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f), 1.0f);
		renderer.material.SetColor("_Color", color);

		for (int i = 0; i < stats.Length; i++) {
			stats[i] = Random.Range(40,60);
		}

	}

	public void moveToPoint(Vector3 point) {
		transform.position = point + new Vector3(0.0f, transform.localScale.y/2, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
