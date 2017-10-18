using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    int bronzePlayer = 0;
    public Text scoreText;
    int silverPlayer = 0;
    //Public makes the variable editable in Unity
    public int miningSpeed = 3;
    int timeToMine;
    //Tells the script that the cube exists
    public GameObject myCube;
    //Vector3 creates a x, y, and z position
    Vector3 cubePosition;
    public GameObject currentCube;
    int goldPlayer;
    public static int goldSupply;
    public static int bronzeSupply;
    public static int silverSupply;
    public static int playerScore;
    public static int cubeColor;
    public static int goldScore = 100;
    public static int silverScore = 10;
    public static int bronzeScore = 1;
    void MakeCube()
    {
        cubePosition = new Vector3(Random.Range (-5f, 5f), Random.Range (-4f, 4f), 0f);
        //Instantiate makes a cube appear using (WhatToInstantiate, WhereToMakeIt, Rotation)
        currentCube = Instantiate(myCube, cubePosition, Quaternion.identity);
        
    }

	// Use this for initialization
	void Start () {
        timeToMine = miningSpeed;
        scoreText.text = "Score: " + playerScore.ToString ();
    }
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToMine)
        {
            if (bronzeSupply == 2 && silverSupply == 2){
                goldPlayer += 1;
                goldSupply += 1;
                MakeCube();
                currentCube.GetComponent<Renderer>().material.color = Color.yellow;
                //Gold = 1, Silver =2, Bronze = 3
                cubeColor = 1;
            }
            else if (bronzeSupply >= 4)
            {
                silverPlayer += 1;
                silverSupply += 1;
                MakeCube();
                currentCube.GetComponent<Renderer>().material.color = Color.gray;
                //Gold = 1, Silver =2, Bronze = 3
                cubeColor = 2;
                
            }
            else if (bronzeSupply < 4) {
                bronzePlayer += 1;
                bronzeSupply += 1;
                MakeCube();
                //This can assign a color using Unity's renderer
                currentCube.GetComponent<Renderer>().material.color = Color.red;
                //Gold = 1, Silver =2, Bronze = 3
                cubeColor = 3;
            }
            //Wait miningSpeed seconds to mine more ore
            timeToMine += miningSpeed;
            //Tell the player how many ore they have
            print("Score:" + playerScore);
            
        }
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
