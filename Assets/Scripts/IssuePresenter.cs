using UnityEngine;
using System.Collections;

public class IssuePresenter : MonoBehaviour {

	public GameObject HUDPrefab;
	public GameObject HeadRollerPrefab;

	private GameObject HUDStats;
	private GameObject HUDIssue;

	private HUDController HUDS;
	private HUDController HUDI;

	public VillagerQueue villagerQueue;
	public VillagerManager villagerManager;
	public IssueManager issueManager;

	public VillagerController curVillager;
	public Issue curIssue;

	public bool presentingIssue = true;
	public bool killedVillager = false;

	// Use this for initialization
	public void Init() {
		HUDStats = Instantiate (HUDPrefab) as GameObject;
		HUDS = HUDStats.GetComponent<HUDController> ();
		HUDS.Init();
		HUDS.HUDtext.fontSize = 24;
		HUDS.HUDtext.characterSize = 0.5f;
		HUDS.resize(new Vector3 (0.5f, 0.6f, 1));
		Vector3 offsetS = new Vector3(-1.0f, 1.0f, 0.0f);
		
		HUDIssue = Instantiate (HUDPrefab) as GameObject;
		HUDI = HUDIssue.GetComponent<HUDController> ();
		HUDI.Init ();
		HUDI.HUDtext.fontSize = 24;
		HUDI.HUDtext.characterSize = 0.5f;
		HUDI.resize(new Vector3 (1.5f, 1f, 1));
		Vector3 offsetI = new Vector3(1.0f, 0.5f, 0.0f);
		
		Vector3 markerPos = villagerQueue.markers[0].transform.position;

		Vector3 HUDSB = HUDS.renderer.bounds.size;
		Vector3 VillB = villagerQueue.villagerInQueue[0].renderer.bounds.size;
		Vector3 newPos = new Vector3(markerPos.x - (HUDSB.x/2+VillB.x/2), HUDSB.y/2 + markerPos.y, HUDSB.z/2 + markerPos.z);
		HUDS.setPosition(newPos + offsetS);
	

		Vector3 HUDIB = HUDI.renderer.bounds.size;
		newPos = new Vector3(markerPos.x + (HUDIB.x/2+VillB.x/2), HUDIB.y/2 + markerPos.y, HUDIB.z/2 + markerPos.z);
		HUDI.setPosition(newPos + offsetI);

		
	}

	public void presentIssue(Issue issue) {

		presentingIssue = true;
		killedVillager = false;

		curIssue = issue;
		curVillager = villagerQueue.getFirstVillager().GetComponent<VillagerController>();
		updateHUDS();
		
		HUDI.resetText ();
		HUDI.addLine("Issue");
		HUDI.addLine("----------");
		HUDI.addLine(curIssue.title);
		HUDI.addLine(curIssue.description);
		HUDI.addLine("");
		for(int i=0; i<curIssue.numOptions; i++) {
			HUDI.addLine("["+(i+1)+"] " + curIssue.options[i].description);
		}
	}

	public void updateHUDS() {
		HUDS.resetText();
		HUDS.addLine("Stats");
		HUDS.addLine("-----------");
		for(int i=0; i<VillagerStats.statNames.Length; i++) {
			HUDS.addLine(VillagerStats.statNames[i] + ": " + curVillager.stats[i]);
		}
	}

	public void getOptionInput() {
		if (Input.GetButtonDown("Option1")) {
			if (curIssue.options[0].all)
				villagerManager.updateVillagersStats(curIssue.options[0].statsModifier);
			else
				curVillager.updateStats(curIssue.options[0].statsModifier);
			updateHUDS();
			presentingIssue = false;
		}
		if (Input.GetButtonDown("Option2")) {
			if (curIssue.options[1].all)
				villagerManager.updateVillagersStats(curIssue.options[1].statsModifier);
			else
				curVillager.updateStats(curIssue.options[1].statsModifier);
			updateHUDS();
			presentingIssue = false;
		}
		if (Input.GetButtonDown("Option3")) {
			if (curIssue.options[2].all) {
				villagerManager.updateVillagersStats(curIssue.options[2].statsModifier);
				villagerManager.removeFirstVillager();
				killedVillager = true;
				//GameObject headRoll = Instantiate (HeadRollerPrefab) as GameObject;
				//headRoll.transform.position = villagerQueue.markers[0].transform.position;
			} else {
				curVillager.updateStats(curIssue.options[2].statsModifier);
			}
			updateHUDS();
			presentingIssue = false;
		}
	}

	void Update() {
		if (presentingIssue) { 
			getOptionInput();
		}
	}
}
