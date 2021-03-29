using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	public GameObject characterController;
	public static AudioSource whisperSound;

	// Use this for initialization
	void Start () {
		whisperSound = DontDestroy.instance.GetComponents<AudioSource>()[0];
	}
	
	// Update is called once per frame
	void Update () {
		if (characterController.transform.position.y < -1) {
			whisperSound.Stop();
			FloorCount.floor = 1;
			SceneManager.LoadScene("GameOver");
		}
	}
}
