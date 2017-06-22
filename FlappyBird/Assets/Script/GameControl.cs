using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public Text scoreText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	private int score = 0;

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

	public void BirdScored() {
		if (!gameOver) {
			score++;
			scoreText.text = "Score: " + score.ToString ();
		}
	}
}
