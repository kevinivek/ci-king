﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class VillagerManager : MonoBehaviour {
	
	private List<GameObject> villagerList = new List<GameObject>();
	public int[] villageStats = {0, 0, 0, 0, 0, 0};

	// Use this for initialization
	void Start () {

		GameObject[] villagers = GameObject.FindGameObjectsWithTag(Tags.villager);
		foreach(GameObject villager in villagers ){
			villagerList.Add(villager);
		}

		for(int i = 0; i < villagerList.Count; i++){
			villagerList[i].GetComponent<VillagerController>().ManualStart();
		}
		UpdateStats();
		
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

		for(int i = 0; i < villageStats.Length; i++){
			Debug.Log(villagerList[0].GetComponent<VillagerController>().statNames[i] + "  " + villageStats[i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}