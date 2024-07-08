using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform PLAYER;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		scoreText.text = PLAYER.position.z.ToString("0");
	}
}
