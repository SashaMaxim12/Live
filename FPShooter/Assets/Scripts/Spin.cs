using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	public float speed = 3.0f; //Объявление общедоступной переменной для скорости вращения

	void Update () {
		transform.Rotate (0, speed, 0); //команда Rotate(вращение) будет запускаться в каждом кадре.
	}
}
