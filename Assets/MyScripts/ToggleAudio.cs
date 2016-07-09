using UnityEngine;
using System.Collections;

public class ToggleAudio : MonoBehaviour {

	public void ToggleSound () {
		AudioSource audio = GetComponent<AudioSource>();
		if (audio.isPlaying) {
			audio.Pause ();

		} else if (audio.isPlaying != true) {
			audio.Play ();
		}
	}
}
