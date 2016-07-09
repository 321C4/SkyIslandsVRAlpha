using UnityEngine;
using System.Collections;

public class SwitchSkybox : MonoBehaviour {
	public Material[] skyMats = new Material[4];
	int index;

	public void switchSkybox () {
		index = Random.Range(0, skyMats.Length);
		RenderSettings.skybox = skyMats [index];
		Debug.Log ("sky switched");
		}
}
