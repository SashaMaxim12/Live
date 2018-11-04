using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin1 : MonoBehaviour {

	public float speed = 3.0f; //Объявление общедоступной переменной для скорости вращения

	void Update () {
		transform.Rotate (speed, 0, 0); //команда Rotate(вращение) будет запускаться в каждом кадре.
	}
}
