using UnityEngine;
using System.Collections;

public class FloatyCycle : MonoBehaviour {

	public float speed;
	public Transform target;

	private IEnumerator Floaty() {
		float step = speed * Time.deltaTime;
		gameObject.transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		yield return new WaitForSeconds (1);
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (Floaty ());
	}
	

}
