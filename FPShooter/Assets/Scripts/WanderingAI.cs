using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {

    public float speed = 3.0f;//значение скорости движения и расстояния
    public float obstacleRange = 5.0f; //переменная для области луча

    private bool _alive;//логическая переменная для слежения за жизнью

    public GameObject fireballPrefab;//будем хранить префаб Fireball
    private GameObject _fireball; //закрытая переменная для слежения за Fireball

    void Start()
    {
        _alive = true; //делаем жизнь в начале истинной
    }
   
    void Update()
    {
        if (_alive)
        {//если враг жив, то
            transform.Translate(0, 0, speed * Time.deltaTime);//непрерывно движемся вперед в каждом кадре
            Ray ray = new Ray(transform.position, transform.forward);//луч в том же положении и направлении, что и персонаж
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {//бросаем луч с описанной окружностью
                GameObject hitObject = hit.transform.gameObject;
                if (hitObject.GetComponent<PlayerCharacter>())
                {//распознаем игрока (если на нем есть скрипт PlayerCharacter)
                    if (_fireball == null)
                    { //пустой игровой объект
                        _fireball = Instantiate(fireballPrefab) as GameObject;//тот же метод как в SceneController
                        //поместим огненый шар перед врагом и нацелим в направлении его движения
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);//Поворот с наполовину случайным значение
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    public void SetAlive(bool alive)
    {//открывает метод,который из вне позволяет воздействовать на переменную жизни
        _alive = alive;
    }

}
