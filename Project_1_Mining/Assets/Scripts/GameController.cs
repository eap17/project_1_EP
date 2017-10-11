using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    int bronzePlayer = 0;
    int silverPlayer = 0;
    //Public makes the variable editable in Unity
    public int miningSpeed = 3;
    int timeToMine;
    //Tells the script that the cube exists
    public GameObject myCube;
    //Vector3 creates a x, y, and z position
    Vector3 cubePosition;
    public float xPosition;
    GameObject currentCube;
    int goldPlayer;
    int goldSupply;
    int bronzeSupply;
    int silverSupply;
    void MakeCube()
    {

    }

	// Use this for initialization
	void Start () {
        timeToMine = miningSpeed;
        //Sets where the cubes will appear, can use Random.Range (min: x, max: y)
        xPosition = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToMine)
        {
            if (bronzePlayer == 2 && silverSupply == 2){
                goldPlayer += 1;
                goldSupply += 1;
                cubePosition = new Vector3(0f + goldPlayer + goldPlayer, 6f, 0f);
                currentCube = Instantiate(myCube, cubePosition, Quaternion.identity);
                currentCube.GetComponent<Renderer>().material.color = Color.yellow;
            }
            if (bronzeSupply >= 4)
            {
                    silverPlayer += 1;
                    silverSupply += 1;
                    cubePosition = new Vector3(0f + silverPlayer + silverPlayer, 4f, 0f);
                    currentCube = Instantiate (myCube, cubePosition, Quaternion.identity);
                    currentCube.GetComponent<Renderer>().material.color = Color.gray; 
            }
            if (bronzePlayer < 4) {
                bronzePlayer += 1;
                bronzeSupply += 1;
                cubePosition = new Vector3(0f + bronzePlayer + bronzePlayer, 2f, 0f);
                //Instantiate makes a cube appear using (WhatToInstantiate, WhereToMakeIt, Rotation)
                currentCube = Instantiate (myCube, cubePosition, Quaternion.identity);
                //This can assign a color using Unity's renderer
                currentCube.GetComponent<Renderer>().material.color = Color.red;
            }
            //Wait miningSpeed seconds to mine more ore
            timeToMine += miningSpeed;
            //Tell the player how many ore they have
            print("Bronze:"+bronzePlayer + ".... Silver:"+silverPlayer);
       }
	}
}
