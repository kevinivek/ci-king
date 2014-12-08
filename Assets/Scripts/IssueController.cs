using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IssueController : MonoBehaviour {
	
	private List<Issue> issues = new List<Issue>();

	// Use this for initialization
	void Start () {
		issues.Add(new Issue ("Farm Disaster", 1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
