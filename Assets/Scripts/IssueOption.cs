using UnityEngine;
using System.Collections;

public class IssueOption{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 

	private int choice = -1; 		//choice number for given issue
	private string description = "";	//description of choice
	private boolean all;
	
	public IssueOption(string description, int choice, int[] stats, boolean all){
		this.choice = choice;
		this.description = description;
		statsModifier = stats;
		this.all = all;
	}	
	
	public string getDescription(){
		return description;
	}
	
	public int getChoice(){
		return choice;
	}
	
	public boolean getAll(){
		return this.all;
	}
	
	public int[] getStats(){
		return statsModifier;
	}
}
