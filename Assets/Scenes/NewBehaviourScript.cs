using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    public Transform a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a.Rotate(0,0,1);
        a.Rotate(1,0,0);
	}
    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0,80,50),"Red")) {
            a.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (GUI.Button(new Rect(100, 0, 80, 50), "Green")) {
            a.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (GUI.Button(new Rect(200, 0, 80, 50), "Blue")) {
            a.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
