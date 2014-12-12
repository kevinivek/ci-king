using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject villagerManager;
	public GameObject villagerQueue;
	public GameObject issuePresenter;

	// Use this for initialization
	void Start () {
		villagerQueue.GetComponent<VillagerQueue>().Init();
		villagerManager.GetComponent<VillagerManager>().Init();
		issuePresenter.GetComponent<IssuePresenter>().Init();

		issuePresenter.GetComponent<IssuePresenter> ().presentIssue ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
