﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDevice : MonoBehaviour {

    public Vector3 dpos;
    private bool _open;

    public void Operate()
    {
        if (_open)
        {
            Vector3 pos = transform.position - dpos;
            transform.position = pos;
        } else
        {
            Vector3 pos = transform.position + dpos;
            transform.position = pos;
        }
        _open = !_open;
    }

    public void Activate ()
    {
        if (!_open)
        {
            Vector3 pos = transform.position + dpos;
            transform.position = pos;
            _open = true;
        }
    }

    public void Deactivate ()
    {
        if (_open)
        {
            Vector3 pos = transform.position - dpos;
            transform.position = pos;
            _open = false;
        }


    }






    // Use this for initialization
    void Start () {
		
	}
	



	// Update is called once per frame
	void Update () {
		
	}
}

