using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    int bronzePlayer = 0;
    int silverPlayer = 0;
    public int miningSpeed = 3;
    public int bronzeSupply = 3;
    int silverSupply = 2;
    int timeToMine;
    //Tells the script that the cube exists
    public GameObject myCube;
    //Creates a x, y, and z position
    Vector3 cubePosition;
    public float xPosition;
    GameObject currentCube;

	// Use this for initialization
	void Start () {
        timeToMine = miningSpeed;
        //Sets where the cubes will appear, can use Random.Range (x, y)
        xPosition = 0;
        cubePosition = new Vector3(xPosition, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToMine)
        {
            //Mine some ore and update the amount of ore the player has
            if (bronzeSupply == 0)
            {
                if (silverSupply > 0)
                {
                    silverPlayer += 1;
                    silverSupply -= 1;
                    currentCube = Instantiate (myCube, cubePosition, Quaternion.identity);
                    currentCube.GetComponent<Renderer>().material.color = Color.gray;
                }
            }
            if (bronzeSupply > 0)
            {
                bronzePlayer += 1;
                bronzeSupply -= 1;
                //Instantiate makes a cube appear using (WhatToInstantiate, WhereToMakeIt, Rotation)
                currentCube = Instantiate (myCube, cubePosition, Quaternion.identity);
                xPosition += 1f;
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
