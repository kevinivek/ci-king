using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject villager;
	public GameObject VillagerHUDPrefab;
	//private GameObject villagerHUD;

	// Use this for initialization
	void Start () {
		GameObject villagerHUD = Instantiate (VillagerHUDPrefab) as GameObject;
		villagerHUD.gameObject.GetComponent<HUDController> ().villager = villager;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.CompareTag (Tags.villager)) {
			VillagerController villCont = hit.gameObject.GetComponent<VillagerController>();
			villCont.stats[ VillagerController.HUNGER ] += 10;
		}
	}
}
