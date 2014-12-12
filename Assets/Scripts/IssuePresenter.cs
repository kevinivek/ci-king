using UnityEngine;
using System.Collections;

public class IssuePresenter : MonoBehaviour {

	public GameObject HUDPrefab;

	private GameObject HUD;

	// Use this for initialization
	public void Init() {
		HUD = Instantiate (HUDPrefab) as GameObject;
		HUDController HUDC = HUD.GetComponent<HUDController> ();
		HUDC.Init();
		HUDC.setPosition(new Vector3(0, 4, -1.5f));
		HUDC.HUDtext.fontSize = 12;
		HUDC.setText("Testing...1..2..3");
		HUDC.resize(new Vector3 (2, 1, 1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
