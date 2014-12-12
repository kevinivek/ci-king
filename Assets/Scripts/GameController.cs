using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public VillagerManager villagerManager;
	public VillagerQueue villagerQueue;
	public IssueManager issueManager;
	public IssuePresenter issuePresenter;

	int state = -1;

	const int PRESENT_ISSUE = 0;
	const int PRESENTING_ISSUE = 1;
	const int NEXT_VILLAGER = 2;

	// Use this for initialization
	void Start () {
		villagerQueue.Init();
		villagerManager.Init();
		issueManager.Init();
		issuePresenter.Init();

		state = PRESENT_ISSUE;
			
	}



	// Update is called once per frame
	void Update () {
		switch (state) {
			case PRESENT_ISSUE:
				issuePresenter.presentIssue(issueManager.getRandomIssue());
				state = PRESENTING_ISSUE;
				break;
			case PRESENTING_ISSUE:
				if(!issuePresenter.presentingIssue)
					state = NEXT_VILLAGER;
				break;
			case NEXT_VILLAGER:
				villagerQueue.nextVillager();
				state = PRESENT_ISSUE;
				break;
		}
	}
}
