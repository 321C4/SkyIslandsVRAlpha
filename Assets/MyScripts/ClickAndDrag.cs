using UnityEngine;
using System.Collections;

public class ClickAndDrag : MonoBehaviour {

	public float yDeg; 
	public float xDeg;
	public float speed;
	public float friction;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			xDeg -= Input.GetAxis ("Mouse X") * speed * friction;
			yDeg += Input.GetAxis ("Mouse Y") * speed * friction;
			Quaternion fromRotation = transform.rotation;
			Quaternion toRotation = Quaternion.Euler (0, xDeg, 0);
			transform.rotation = Quaternion.Lerp (fromRotation, toRotation, Time.deltaTime * 2.0f);
		}
	
	}
}
