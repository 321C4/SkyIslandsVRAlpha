using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {

	public Camera face_camera;

	// Update is called once per frame
	void Update () {
		transform.LookAt (transform.position + face_camera.transform.rotation * Vector3.forward, 
			face_camera.transform.rotation * Vector3.up);
	
	}
}
