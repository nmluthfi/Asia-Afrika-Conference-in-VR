using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToFirstScene : MonoBehaviour {

	public void GoToScene() {
		SceneManager.LoadScene("first_scene");
	}
}
