using UnityEngine;
using System.Collections;

public class IssueOption{

	public string description = "";	//description of choice
	public int choice = -1; 		//choice number for given issue
	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	public bool all;
	
	public IssueOption(string description, int choice, int[] stats, bool all){
		this.choice = choice;
		this.description = description;
		this.statsModifier = stats;
		this.all = all;
	}	

}
