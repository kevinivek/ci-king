using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IssueManager : MonoBehaviour {
	
	public List<Issue> issues = new List<Issue>();

	// Use this for initialization
	public void Init () {
		issues.Add(new Issue ("Farm Disaster", 3));
		issues[0].setDescription(" \"Half my farm burned down in a fire,\n I'm not going to be able to make\n any money this season, let alone\n feed my family.\"");
		issues[0].addOption("Give him some grain", new int[] {0, -10, 10, 0, 0, -10}, false); //subtract from food stores
		issues[0].addOption("Diplomatically Refuse to do anything", new int[] {0, 5, 0, 0, 10, 20}, false);
		issues[0].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers

		issues.Add (new Issue ("Missing Child", 3));
		issues[1].setDescription ("My daughter went down to play in the river, and she never came back, we can't find her anywhere around town, will you help us?");
		issues[1].addOption ("Send help right away", new int[] {-10, -10, 10, 0, 0, 0}, false);  //subtract money from the coffers
		issues[1].addOption("Find the child, but force her into labor at the castle", new int[] {0, 10, -10, 10, 10, 0}, false);
		issues[1].addOption("Have him beheaded for suggesting you stoop to helping him", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers

		issues.Add (new Issue ("Lower Taxes", 3));
		issues[2].setDescription ("The taxes are so high as to be crippling sire, will you please show some mercy?");
		issues[2].addOption ("Lower the taxes", new int[] {0, -10, 10, 0, -10, 0}, false);
		issues[2].addOption ("Raise the taxes", new int[] {0, 10, 0, 5, 10, 0}, false);
		issues[2].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers
		
		issues.Add (new Issue ("That Weird Guy", 3));
		issues[3].setDescription ("There is a man who moved into your village recently, and he is exceptionally strange.  Can you do something about him?");
		issues[3].addOption ("Show Acceptance of the man", new int[] {10, 0, 0, 10, 0, 0}, true); 
		issues[3].addOption ("Ignore the villager", new int[] {0, 0, 0, 0, 10, 0}, true);
		issues[3].addOption("Kill the new man", new int[] {-10, 0, 5, 5, -10, 0}, true); //stats will need to affect all other villagers
		
		issues.Add (new Issue ("Conscription", 3));
		issues[4].setDescription ("Sire, I don't feel safe with all the dangers in this world, you should conscript all the young people to fight for our security");
		issues[4].addOption ("Refuse, that sounds expensive", new int[] {0, 0, -10, 10, 10, 0}, false);
		issues[4].addOption ("Of Course! More Soldiers!", new int[] {0, 10, 0, 5, -5, 0}, true);
		issues[4].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers
		
		issues.Add (new Issue ("Build a School", 3));
		issues[5].setDescription ("Could you build a school for our children to be educated in?  I think it woulld greatly benefit your realm.");
		issues[5].addOption ("Sounds good to me", new int[] {0, -10, 10, 0, -15, 5}, true);  //should subtract a large amount of money
		issues[5].addOption ("We can't afford that", new int[] {0, 10, -15, 0, 10, -5}, false);
		issues[5].addOption("Have him beheaded for his insolence", new int[] {10, 5, 0, 5, 0, 0}, true); //stats will need to affect all other villagers
		
	}

	public Issue getRandomIssue() {
		return issues[Random.Range(0, issues.Count-1)];
	}

}
