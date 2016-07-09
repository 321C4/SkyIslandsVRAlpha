using UnityEngine;
using System.Collections;

public class ColorChangeFloat : MonoBehaviour {

	public float rSliderFloat = 0f;
	public float bSliderFloat = 0f;
	public float gSliderFloat = 0f;
	public GameObject thing;

	public void ChangeRvalue (float val) {
		rSliderFloat = val;
	}

	public void ChangeBvalue (float val) {
		bSliderFloat = val;
	}

	public void ChangeGvalue (float val) {
		gSliderFloat = val;
	}

	void Update () {
		thing.GetComponent<Renderer>().material.color = new Color (rSliderFloat, gSliderFloat, bSliderFloat, 1);
	}


}
