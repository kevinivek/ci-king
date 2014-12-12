using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IssueManager : MonoBehaviour {
	
	private List<Issue> issues = new List<Issue>();

	// Use this for initialization
	void Start () {
		issues.Add(new Issue ("Farm Disaster", 3));
		issues[0].setDescription("Half my farm burned down in a fire, I'm not going to be able to make any money this season, let alone feed my family.");
		issues[0].addOption("Give him some grain", new int[] {0, -10, 10, 0, 0, -10}, false); //subtract from food stores
		issues[0].addOption("Diplomatically Refuse to do anything", new int[] {0, -10, 10, 0, 0, -10}, false);
		issues[0].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers

		issues.Add (new Issue ("Missing Child", 3));
		issues [1].setDescription ("My daughter went down to play in the river, and she never came back, we can't find her anywhere around town, will you help us?");
		issues [1].addOption ("Send help right away", new int[] {-10, -10, 10, 0, 0, 0}, false);  //subtract money from the coffers
		issues[1].addOption("Find the child, but force her into labor at the castle", new int[] {0, 10, -10, 10, 10, 0}, false);
		issues[1].addOption("Have him beheaded for suggesting you stoop to helping him", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers

		issues.Add (new Issue ("Lower Taxes", 3));
		issues [2].setDescription ("The taxes are so high as to be crippling sire, will you please show some mercy?");
		issues [2].addOption ("Lower the taxes", new int[] {0, -10, 10, 0, -10, 0}, false);
		issues [2].addOption ("Raise the taxes", new int[] {0, 10, 0, 5, 10, 0}, false);
		issues[2].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Issue getIssue()
	{
		return issues [issues.Count];
	}

	void removeIssue()
	{

	}

	public Issue getIssue(int pos)
	{
		return issues [pos];
	}

}
