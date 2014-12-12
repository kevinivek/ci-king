using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VillagerQueue : MonoBehaviour {

	public GameObject[] markers;
	public List<GameObject> villagerInQueue = new List<GameObject>();

	// Use this for initialization
	public void Init() {
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
		for(int i=0; i<villagerInQueue.Count; i++) {
			moveVillagerToMarker(villagerInQueue[i], markers[i]);
		}
	}

	private void moveVillagerToMarker(GameObject villager, GameObject marker) {
		villager.GetComponent<VillagerController>().moveToPoint(marker.transform.position);
	}

	public GameObject getFirstVillager() {
		return villagerInQueue[0];
	}

	public void nextVillager() {
		GameObject villager = getFirstVillager();
		popVillager();
		pushVillager(villager);
	}

}
