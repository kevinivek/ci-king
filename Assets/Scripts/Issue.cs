using UnityEngine;
using System.Collections;

public class Issue : MonoBehaviour {

	public int[] statsModifier = {0, 0, 0, 0, 0, 0}; 
	public string[] statNames = {"Fear", "Depression", "Joy", "Anger", "Apathy", "Hunger"}; 
	public const int FEAR = 0;
	public const int DEPRESSION = 1;
	public const int JOY = 2;
	public const int ANGER = 3;
	public const int APATHY = 4;
	public const int HUNGER = 5;
	
	private String title = "";
	private String description = "";
	private int numOptions = 0; //the number of options in this issue, starts with zero
	private IssueOption[] options;
	
	public Issue(String title, int num){
		this.title = title;
		options = new IssueOption[num];
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public String getTitle(){
		return this.title;
	}
	
	public String getDescription(){
		return this.description;
	}
	public void addOption(String oName, int stats[]){
		options[numOptions] = new Issue(oName, numOptions + 1, stats);
		numOptions++;
	}
	
	public option getOption(int oNum)
	{
		return options[oNum];
	}
	
	
}
