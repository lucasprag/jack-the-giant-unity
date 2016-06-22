using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

	[SerializeField]
	private Text scoreText, coinText;

	void Start () {
		SetScoreBasedOnDifficulty ();
	}

	void SetScore(int score, int coinScore) {
		scoreText.text = score.ToString ();
		coinText.text = coinScore.ToString ();
	}

	void SetScoreBasedOnDifficulty() {

		if (GamePreferences.GetEasyDifficulty () == 1) {
			SetScore (GamePreferences.GetEasyDifficultyHighScore (), GamePreferences.GetEasyDifficultyCoinScore ());
		}

		if (GamePreferences.GetMediumDifficulty () == 1) {
			SetScore (GamePreferences.GetMediumDifficultyHighScore (), GamePreferences.GetMediumDifficultyCoinScore ());
		}

		if (GamePreferences.GetHardDifficulty () == 1) {
			SetScore (GamePreferences.GetHardDifficultyHighScore (), GamePreferences.GetHardDifficultyCoinScore ());
		}
	}

	public void GoBackToMainMenu () {
		SceneFader.instance.LoadLevel ("MainMenu");
	}
}
