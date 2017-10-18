using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeBehaviorScript : MonoBehaviour {
    string cubeType;
    public Text scoreText;
    void SetScoreText () {
        scoreText.text = "Score: " + GameController.playerScore.ToString();
    }

    // Use this for initialization
    void Start () {
		if (GameController.cubeColor == 1) { cubeType = "gold"; }
        if (GameController.cubeColor == 2) { cubeType = "silver"; }
        if (GameController.cubeColor == 3) { cubeType = "bronze"; }
	}
    private void OnMouseDown()
    {
        if (cubeType == "gold")
        {
            GameController.goldSupply -= 1;
            GameController.playerScore += GameController.goldScore;
            SetScoreText();
        }
        if (cubeType == "silver")
        {
            GameController.silverSupply -= 1;
            GameController.playerScore += GameController.silverScore;
            SetScoreText();
        }
        if (cubeType == "bronze")
        {
            GameController.bronzeSupply -= 1;
            GameController.playerScore += GameController.bronzeScore;
            SetScoreText();
        }
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
