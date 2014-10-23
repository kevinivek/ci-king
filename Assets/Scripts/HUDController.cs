using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public GameObject text;
	public GameObject villager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		VillagerController villCont = villager.gameObject.GetComponent<VillagerController>();

		text.GetComponent<TextMesh>().text = 
			"Villager" + "\n" + 
			"Joy: " + villCont.joy + "\n" + 
			"Fear: " + villCont.fear + "\n";


	}
}
