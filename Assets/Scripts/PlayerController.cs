using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject villager;
	public GameObject VillagerHUDPrefab;
	private GameObject villagerHUD;
	
	private int coffers;
	private int food;

	// Use this for initialization
	void Start () {
		villagerHUD = Instantiate (VillagerHUDPrefab) as GameObject;
		villagerHUD.gameObject.GetComponent<HUDController> ().villager = villager;
		coffers = 200;
		good = 200;
	}
	
	// Update is called once per frame
	void Update () {

//		Vector3 fwd = transform.TransformDirection (Vector3.forward);
//		RaycastHit hit;
//
//		GameObject cam = GameObject.FindGameObjectWithTag ("MainCamera");
//
//		Debug.DrawRay (cam.transform.position, fwd, Color.red);
//
//		HUDController HUDCont = villagerHUD.gameObject.GetComponent<HUDController>();
//
//		if(Physics.Raycast(cam.transform.position, fwd, out hit)) {
//			if(hit.collider.gameObject.CompareTag(Tags.villager)) {
//				if(!HUDCont.activeHUD) {
//					HUDCont.villager = hit.collider.gameObject;
//					HUDCont.setPosition();
//				}
//			}
//			else {
//				if(HUDCont.activeHUD) {
//					HUDCont.villager = null;
//					HUDCont.resetPosition();
//				}
//			}
//		}
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.CompareTag (Tags.villager)) {
			VillagerController villCont = hit.gameObject.GetComponent<VillagerController>();
			villCont.stats[ VillagerStats.HUNGER ] += 10;
		}
	}
	
	public void addCoffers(int gold){
		this.coffers += gold;
	}
	
	public void addFood(int food){
		this.food +=food;
	}
	
	public int getCoffers(){
		return this.coffers;
	}
	
	public int getFood(){
		return this.food;
	}
}
