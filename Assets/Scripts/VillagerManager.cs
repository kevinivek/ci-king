using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class VillagerManager : MonoBehaviour {
	
	public List<GameObject> villagerList = new List<GameObject>();
	public int[] villageStats = {0, 0, 0, 0, 0, 0};
	public VillagerQueue villagerQueue;

	// Use this for initialization
	public void Init () {

		//--Initializations

		//------villagers
		GameObject[] villagers = GameObject.FindGameObjectsWithTag(Tags.villager);
		foreach(GameObject villager in villagers){
			villager.GetComponent<VillagerController>().Init();
		}


		//--get all villagers
		foreach(GameObject villager in villagers){
			villagerList.Add(villager);
		}
		UpdateStats();


		//Add villagers to queue
		foreach(GameObject villager in villagerList) {
			villagerQueue.pushVillager(villager);
		}

	}

	//Updates the stats for the whole village.  Averages the stats for the whole village
	void UpdateStats(){
		foreach(GameObject villager in villagerList){
			for(int i = 0; i < villageStats.Length; i++){
				villageStats[i] += villager.GetComponent<VillagerController>().stats[i];
			}
		}
		for(int i = 0; i < villageStats.Length; i++){
			villageStats[i] /= villagerList.Count;
		}

		//for(int i = 0; i < villageStats.Length; i++){
		//	Debug.Log(villagerList[0].GetComponent<VillagerController>().statNames[i] + "  " + villageStats[i]);
		//}

	}

	public void updateVillagersStats(int[] stats) {
		foreach(GameObject villager in villagerList) {
			villager.GetComponent<VillagerController>().updateStats(stats);
		}
	}

	public void removeVillager(GameObject villager) {
		villagerList.Remove(villager);
		villagerQueue.villagerInQueue.Remove(villager);
		villagerQueue.updateQueue();
	}

	public void removeFirstVillager() {
		GameObject villager = villagerList[0];
		villagerList.RemoveAt(0);
		villagerQueue.villagerInQueue.RemoveAt(0);
		GameObject.Destroy(villager);
		villagerQueue.updateQueue();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
