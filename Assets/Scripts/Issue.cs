using UnityEngine;
using System.Collections;

public class Issue{

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	
	public string title = "";
	public string description = "";
	public int numOptions = 0; //the number of options in this issue, starts with zero
	public IssueOption[] options;
	
	public Issue(string title, int num){
		this.title = title;
		options = new IssueOption[num];
	}
	
	//Formats the description to have a return after every 35 characters
	public void setDescription(string original){
//		string newDescription = "";
//		int startPos = 0;
//		int line = 35;
//		int origLength = original.Length;
//		while(origLength > line){
//			newDescription += (original.Substring(startPos * line, (startPos + 1) * line)) + " \n ";
//			origLength -= line;
//		}
//		
		this.description = original;

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
