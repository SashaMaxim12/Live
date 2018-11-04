using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    public float speed = 10.0f; //переменная для скорости Fireball
    public int damage = 1; // переменная урона

    void Update () 
    {
        transform.Translate (0, 0, speed * Time.deltaTime); // движение Fireball по оси z (куда смотрит враг)
    }

    void OnTriggerEnter(Collider other)
    {//вызывается когда с триггером сталкивается другой объект
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player!=null)
        {//проверяем, является ли объект PlayerCharacter (установлен ли на объекте данный скрипт)
            player.Hurt(damage);
        }
        Destroy (this.gameObject); // уничтожаем объект
    }
}
