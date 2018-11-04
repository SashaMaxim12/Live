using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometa : MonoBehaviour {

    public float speed = 1.0f;
    public float maxZ = 16.0f;
    public float minZ = -16.0f;

    private float _direction = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, _direction * speed * Time.deltaTime);
        bool bounced = false;
        if(transform.position.z > maxZ || transform.position.z < minZ)
        {
            _direction = -_direction;
            bounced = true;

        }
        if(bounced == true)
        {
            transform.Translate(0, 0, _direction * speed * Time.deltaTime);
        }

	}
}
