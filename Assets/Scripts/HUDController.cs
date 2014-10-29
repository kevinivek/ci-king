using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public GameObject text;
	public GameObject villager;

	// Use this for initialization
	void Start () {
		Vector3 newPos = villager.transform.position;
		newPos.x += this.renderer.bounds.size.x/2 + villager.renderer.bounds.size.x/2 + 0.5f;
		newPos.y += villager.renderer.bounds.size.y/2 + 0.5f;
		this.transform.Translate (newPos);
	}
	
	// Update is called once per frame
	void Update () {
	
		VillagerController villCont = villager.gameObject.GetComponent<VillagerController>();

		text.GetComponent<TextMesh> ().text = "Villager\n----------------------\n";

		for (int i=0; i<villCont.stats.Length; i++) {
			text.GetComponent<TextMesh>().text += villCont.statNames[i] + ": " + villCont.stats[i] + "\n";
		}

	}
}
