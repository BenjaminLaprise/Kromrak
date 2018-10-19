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
	void Update () {
        if (Input.GetKeyUp("w") && currentRoom.north) {
            Debug.Log("You move in a northernly direction.");
            currentRoom = currentRoom.north.Enter();
        }
        if (Input.GetKeyUp("a") && currentRoom.west) {
            Debug.Log("You move in a westernly direction.");
            currentRoom = currentRoom.west.Enter();
        }
        if (Input.GetKeyUp("s") && currentRoom.south) {
            Debug.Log("You move in a southernly direction.");
            currentRoom = currentRoom.south.Enter();
        }
        if (Input.GetKeyUp("d") && currentRoom.east) {
            Debug.Log("You move in an easternly direction.");
            currentRoom = currentRoom.east.Enter();
        }
    }
}
