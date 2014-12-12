using UnityEngine;
using System.Collections;

public class IssuePresenter : MonoBehaviour {

	public GameObject HUDPrefab;

	private GameObject HUDStats;
	private GameObject HUDIssue;

	public VillagerQueue villagerQueue; 

	// Use this for initialization
	public void Init() {
		HUDStats = Instantiate (HUDPrefab) as GameObject;
		HUDController HUDS = HUDStats.GetComponent<HUDController> ();
		HUDS.Init();
		HUDS.setPosition(new Vector3(0, 4, -1.5f));
		HUDS.HUDtext.fontSize = 12;
		HUDS.setText("Testing...1..2..3");
		HUDS.resize(new Vector3 (0.5f, 1, 1));
		
		HUDIssue = Instantiate (HUDPrefab) as GameObject;
		HUDController HUDI = HUDIssue.GetComponent<HUDController> ();
		HUDI.Init();
		HUDI.setPosition(new Vector3(0, 4, -1.5f));
		HUDI.HUDtext.fontSize = 12;
		HUDI.setText("Testing...1..2..3");
		HUDI.resize(new Vector3 (1, 0.5f, 1));
		
		Vector3 markerPos = villagerQueue.markers[0].transform.position;

		Vector3 HUDSB = HUDS.renderer.bounds.size;
		Vector3 VillB = villagerQueue.villagerInQueue[0].renderer.bounds.size;
		Vector3 newPos = new Vector3(markerPos.x - (HUDSB.x/2+VillB.x/2), HUDSB.y/2 + markerPos.y, HUDSB.z/2 + markerPos.z);
		HUDS.setPosition(newPos);

		Vector3 HUDIB = HUDI.renderer.bounds.size;
		newPos = new Vector3(markerPos.x + (HUDIB.x/2+VillB.x/2), HUDIB.y/2 + markerPos.y, HUDIB.z/2 + markerPos.z);
		HUDI.setPosition(newPos);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
