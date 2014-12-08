using UnityEngine;
using System.Collections;

public class Issue{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	public string[] statNames = {"Fear", "Depression", "Joy", "Anger", "Apathy", "Hunger"}; 
	public const int FEAR = 0;
	public const int DEPRESSION = 1;
	public const int JOY = 2;
	public const int ANGER = 3;
	public const int APATHY = 4;
	public const int HUNGER = 5;
	
	private string title = "";
	private string description = "";
	private int numOptions = 0; //the number of options in this issue, starts with zero
	private IssueOption[] options;
	
	public Issue(string title, int num){
		this.title = title;
		options = new IssueOption[num];
	}

	public void setDescription(string description){
		this.description = description;
	}
	
	public string getTitle(){
		return this.title;
	}
	
	public string getDescription(){
		return this.description;
	}
	public void addOption(string oName, int[] stats){
		options[numOptions] = new IssueOption(oName, numOptions + 1, stats);
		numOptions++;
	}
	
	public IssueOption getOption(int oNum)
	{
		return options[oNum];
	}
	
	
}
