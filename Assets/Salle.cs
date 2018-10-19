using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salle : MonoBehaviour {

    public Salle north;
    public Salle south;
    public Salle east;
    public Salle west;

    // Use this for initialization
    void Start () {
        Debug.Log("Bravo, une salle existe!");
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
