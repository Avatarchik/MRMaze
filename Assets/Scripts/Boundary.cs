using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {

	//Game controller object set in UnityEngine.
//	public GameObject gameControllerObject;
//	GameController gameController;

	void Start(){
//		gameController = gameControllerObject.GetComponent<GameController> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Ball") {
			Destroy (other.gameObject);
		}

//		//Changes scene to "Restart" scene.
//		if (gameController.gameLives < 1) {
//			SceneManager.LoadScene ("ScoreSubmission");
//		}
	}
}
