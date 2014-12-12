using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public VillagerManager villagerManager;
	public VillagerQueue villagerQueue;
	public IssueManager issueManager;
	public IssuePresenter issuePresenter;

	// Use this for initialization
	void Start () {
		villagerQueue.Init();
		villagerManager.Init();
		issueManager.Init();
		issuePresenter.Init();

		issuePresenter.presentIssue();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
