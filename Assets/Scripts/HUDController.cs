using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public GameObject text;
	public GameObject villager;
	public bool activeHUD = false;

	// Use this for initialization
	void Start () {
		resetPosition();
	}
	
	// Update is called once per frame
	void Update () {
		if (villager == null || !activeHUD) {
			text.GetComponent<TextMesh>().text = "";
		} else if(villager !=null && activeHUD) {
			VillagerController villCont = villager.gameObject.GetComponent<VillagerController>();

			text.GetComponent<TextMesh>().text = "Villager\n----------------------\n";

			for (int i=0; i<villCont.stats.Length; i++) {
				text.GetComponent<TextMesh>().text += villCont.statNames[i] + ": " + villCont.stats[i] + "\n";
			}
		}
	}

	public void setPosition(){
		activeHUD = true;
		Vector3 newPos = villager.transform.position;
		newPos.x += this.renderer.bounds.size.x/2 + villager.renderer.bounds.size.x/2 + 0.5f;
		newPos.y += villager.renderer.bounds.size.y/2 + 0.5f;
		this.transform.position = newPos;
	}

	public void resetPosition() {
		activeHUD = false;
		this.transform.position = new Vector3(20, 0, 20);
	}
}
