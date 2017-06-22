using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdDied() {
		gameOver = true;
		gameOverText.SetActive (true);
	}
}
