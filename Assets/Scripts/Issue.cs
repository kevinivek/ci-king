using UnityEngine;
using System.Collections;

public class Issue{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	
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
	public void addOption(string oName, int[] stats, bool all){
		options[numOptions] = new IssueOption(oName, numOptions + 1, stats, all);
		numOptions++;
	}
	
	public IssueOption getOption(int oNum)
	{
		return options[oNum];
	}
	
	
}
