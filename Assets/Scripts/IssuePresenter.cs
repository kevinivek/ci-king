using UnityEngine;
using System.Collections;

public class IssuePresenter : MonoBehaviour {

	public GameObject HUDPrefab;

	private GameObject HUD;

	// Use this for initialization
	public void Init() {
		HUD = Instantiate (HUDPrefab) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
