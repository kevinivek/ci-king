using UnityEngine;
using System.Collections;

public class IssueOption{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 

	private int choice = -1; 		//choice number for given issue
	private string description = "";	//description of choice
	
	public IssueOption(string description, int choice, int[] stats){
		this.choice = choice;
		this.description = description;
		statsModifier = stats;
	}	
	
	public string getDescription(){
		return description;
	}
	
	public int getChoice(){
		return choice;
	}
	
	public int[] getStats(){
		return statsModifier;
	}
}
