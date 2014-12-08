using UnityEngine;
using System.Collections;

public class IssueOption : MonoBehaviour {

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	public string[] statNames = {"Fear", "Depression", "Joy", "Anger", "Apathy", "Hunger"}; 
	public const int FEAR = 0;
	public const int DEPRESSION = 1;
	public const int JOY = 2;
	public const int ANGER = 3;
	public const int APATHY = 4;
	public const int HUNGER = 5;
	private int choice = -1; 		//choice number for given issue
	private String description = "";	//description of choice
	
	public IssueOption(String description, int choice, int stats[]){
		this.choice = choice;
		this.description = description;
		statsModifier = stats;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public String getDescription(){
		return description;
	}
	
	public int getChoice(){
		return choice;
	}
	
	public int[] getStats(){
		return statsModifier();
	}
}
