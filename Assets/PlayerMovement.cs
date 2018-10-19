using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Salle currentRoom;


	// Use this for initialization
	void Start () {
        Debug.Log("Krom existe!");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp("w"))
        {
            currentRoom = currentRoom.north;
            Debug.Log("WwwWwWWWWWWWWWWWWW");
        }
        if (Input.GetKeyUp("a"))
        {
            currentRoom = currentRoom.west;
            Debug.Log("Aaa!");
        }
        if (Input.GetKeyUp("s"))
        {
            currentRoom = currentRoom.south;
            Debug.Log("Sss!");
        }
        if (Input.GetKeyUp("d"))
        {
            currentRoom = currentRoom.east;
            Debug.Log("Ddd!");
        }
    }
}
