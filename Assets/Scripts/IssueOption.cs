using UnityEngine;
using System.Collections;

public class IssueOption{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	public string[] statNames = {"Fear", "Depression", "Joy", "Anger", "Apathy", "Hunger"}; 
	public const int FEAR = 0;
	public const int DEPRESSION = 1;
	public const int JOY = 2;
	public const int ANGER = 3;
	public const int APATHY = 4;
	public const int HUNGER = 5;
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
