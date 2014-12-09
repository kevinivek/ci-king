using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VillagerQueue : MonoBehaviour {

	public GameObject[] markers;
	public List<GameObject> villagerInQueue = new List<GameObject>();

	// Use this for initialization
	public void ManualStart () {
		GameObject[] tempMarkers = GameObject.FindGameObjectsWithTag(Tags.villagerMarker);
		int numMarker = tempMarkers.Length;
		markers = new GameObject[numMarker];
		foreach(GameObject marker in tempMarkers ){
			int id = marker.GetComponent<MarkerController>().id;
			markers[id] = marker;
		}

	}



	public void pushVillager(GameObject villager) {
		villagerInQueue.Add(villager);
		updateQueue();
	}

	public void popVillager() {
		villagerInQueue.RemoveAt(0);
		updateQueue();
	}

	private void updateQueue() {
		Debug.Log("villagers in queue: #" + villagerInQueue.Count);
		for(int i=0; i<villagerInQueue.Count; i++) {
			Debug.Log("villager [" +i+ "]: " + villagerInQueue[i]);
			Debug.Log ("markers [" +i+ "]: " + markers[i]);
			moveVillagerToMarker(villagerInQueue[i], markers[i]);
		}
	}

	private void moveVillagerToMarker(GameObject villager, GameObject marker) {
		villager.GetComponent<VillagerController>().moveToPoint(marker.transform.position);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
