using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public GameObject text;
	public GameObject villager;
	public bool activeHUD = false;
	public Vector3 storePosition = new Vector3(20,0,20);

	// Use this for initialization
	void Start () {
		resetPosition();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void setText(string newText) {
		text.GetComponent<TextMesh>().text = newText;
	}

	public void addLine(string line) {
		text.GetComponent<TextMesh>().text += line;
	}

	public void setPosition(Vector3 newPos) {
		activeHUD = true;
		//Vector3 newPos = villager.transform.position;
		//newPos.x += this.renderer.bounds.size.x/2 + villager.renderer.bounds.size.x/2 + 0.5f;
		//newPos.y += villager.renderer.bounds.size.y/2 + 0.5f;
		this.transform.position = newPos;
	}

	public void resetPosition() {
		activeHUD = false;
		this.transform.position = storePosition;
	}

	public void resize(Vector3 modScale) {
		Vector3 scale = transform.localScale;
		Vector3 newScale = new Vector3( scale.x*modScale.x, scale.y*modScale.y, scale.z*modScale.z );
		transform.localScale = newScale;

		scale = text.transform.localScale;
		newScale = new Vector3( scale.x*modScale.x, scale.y*modScale.y, scale.z*modScale.z );
		text.transform.localScale = newScale;
	}
}
