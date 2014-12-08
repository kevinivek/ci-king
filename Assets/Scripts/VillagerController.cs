using UnityEngine;
using System.Collections;
using System.Runtime;

public class VillagerController : MonoBehaviour {

	public int[] stats = {0, 0, 0, 0, 0, 0};
	public string[] statNames = {"Fear", "Depression", "Joy", "Anger", "Apathy", "Hunger"}; 
	public const int FEAR = 0;
	public const int DEPRESSION = 1;
	public const int JOY = 2;
	public const int ANGER = 3;
	public const int APATHY = 4;
	public const int HUNGER = 5;
	
	// Use this for initialization
	void Start () {

	}

	public void ManualStart(){
		for (int i = 0; i < stats.Length; i++) {
			stats[i] = Random.Range(40,60);
		}
		
		GameObject[] markers = GameObject.FindGameObjectsWithTag(Tags.villagerMarker);
		
		foreach(GameObject marker in markers ){
			if (marker.GetComponent<MarkerController>().id==0) {
				transform.position = marker.transform.position + new Vector3(0.0f, transform.localScale.y/2, 0.0f);
			}
		}
		
		Debug.Log ("Village Controller: " + stats[0]);


		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
