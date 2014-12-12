using UnityEngine;
using System.Collections;

public class IssuePresenter : MonoBehaviour {

	public GameObject HUDPrefab;

	private GameObject HUDStats;
	private GameObject HUDIssue;

	private HUDController HUDS;
	private HUDController HUDI;

	public VillagerQueue villagerQueue;
	public IssueManager issueManager;

	// Use this for initialization
	public void Init() {
		HUDStats = Instantiate (HUDPrefab) as GameObject;
		HUDS = HUDStats.GetComponent<HUDController> ();
		HUDS.Init();
		HUDS.setPosition(new Vector3(0, 4, -1.5f));
		HUDS.HUDtext.fontSize = 24;
		HUDS.HUDtext.characterSize = 0.5f;
		HUDS.resize(new Vector3 (0.5f, 1, 1));
		
		HUDIssue = Instantiate (HUDPrefab) as GameObject;
		HUDI = HUDIssue.GetComponent<HUDController> ();
		HUDI.Init();
		HUDI.setPosition(new Vector3(0, 4, -1.5f));
		HUDI.HUDtext.fontSize = 24;
		HUDI.HUDtext.characterSize = 0.5f;
		HUDI.resize(new Vector3 (1, 0.5f, 1));
		
		Vector3 markerPos = villagerQueue.markers[0].transform.position;

		Vector3 HUDSB = HUDS.renderer.bounds.size;
		Vector3 VillB = villagerQueue.villagerInQueue[0].renderer.bounds.size;
		Vector3 newPos = new Vector3(markerPos.x - (HUDSB.x/2+VillB.x/2), HUDSB.y/2 + markerPos.y, HUDSB.z/2 + markerPos.z);
		Vector3 offset = new Vector3(0.0f, 0.0f, 0.0f);
		HUDS.setPosition(newPos + offset);

		Vector3 HUDIB = HUDI.renderer.bounds.size;
		newPos = new Vector3(markerPos.x + (HUDIB.x/2+VillB.x/2), HUDIB.y/2 + markerPos.y, HUDIB.z/2 + markerPos.z);
		offset = new Vector3(0.0f, 0.0f, 0.0f);
		HUDI.setPosition(newPos + offset);
		
	}

	public void presentIssue() {

		VillagerController curVillager = villagerQueue.getFirstVillager().GetComponent<VillagerController>();
		HUDS.resetText();
		HUDS.addLine("Stats");
		HUDS.addLine("-----------");
		for(int i=0; i<VillagerStats.statNames.Length; i++) {
			HUDS.addLine(VillagerStats.statNames[i] + ": " + curVillager.stats[i]);
		}

		Issue curIssue = issueManager.issues[0];
		HUDI.resetText ();
		HUDI.addLine("Issue");
		HUDI.addLine("----------");
		HUDI.addLine(curIssue.title);
		HUDI.addLine (curIssue.description);
		for(int i=0; i<curIssue.numOptions; i++) {
			HUDI.addLine("["+i+"] " + curIssue.options[i].description);
		}

	}
}
