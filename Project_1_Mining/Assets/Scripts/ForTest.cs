using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //int[] creates an array, which can hold multiple ints
        //Use this format to set up arrays with the x in (new int[x]) as the number of ints that the array holds.
        int[] temperatures = new int[5];
	}
	
	// Update is called once per frame
	void Update () {
        //The command "for" is used to do a something multiple times
        //The ++ command adds 1 to whatever you put before it
        for (int Sample = 1; Sample <= 1000; Sample++)
        {
            print(Sample);
        }
		
	}
}
