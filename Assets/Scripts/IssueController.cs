using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IssueController : MonoBehaviour {
	
	private List<Issue> issues = new List<Issue>();

	// Use this for initialization
	void Start () {
		issues.Add(new Issue ("Farm Disaster", 3));
		issues.setDescription("Half my farm burned down in a fire, I'm not going to be able to make any money this season, let alone feed my family.");
		issues[0].addOption("Give him some grain", {0, -10, 10, 0, 0, -10});
		issues[0].addOption("Diplomatically Refuse to do anything", {0, -10, 10, 0, 0, -10});
		issues[0].addOption("Have him beheaded for his insolence", {10, 5, 0, 5, 0, 0}); //stats will need to affect all other villagers
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
