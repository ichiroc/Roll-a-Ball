using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class DangerWall : MonoBehaviour {
	void OnCollisionEnter(Collision hit){
		if (hit.gameObject.CompareTag("Player")) {
			int sceneIndex = EditorSceneManager.GetActiveScene ().buildIndex;
			EditorSceneManager.LoadScene (sceneIndex);
		}
	}
}
