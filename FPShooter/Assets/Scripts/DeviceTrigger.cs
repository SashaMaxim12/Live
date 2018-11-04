using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceTrigger : MonoBehaviour {

    public GameObject[] targets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject target in targets) 
        {

            target.SendMessage("Activate");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject target in targets)
        {

            target.SendMessage("Deactivate");

        }
    }





}
