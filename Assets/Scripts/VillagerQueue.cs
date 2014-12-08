using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VillagerQueue : MonoBehaviour {

	private GameObject[] markers;
	private List<GameObject> villagerInQueue = new List<GameObject>();

	// Use this for initialization
	void Start () {
		GameObject[] tempMarkers = GameObject.FindGameObjectsWithTag(Tags.villagerMarker);
		int numMarker = tempMarkers.Length;
		markers = new GameObject[numMarker];
		foreach(GameObject marker in tempMarkers ){
			int id = marker.GetComponent<MarkerController>().id;
			markers[id] = marker;
		}

		foreach(GameObject marker in markers) {
			Debug.Log("marker: " + marker.GetComponent<MarkerController>().id);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
