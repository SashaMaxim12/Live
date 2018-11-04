using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    private int _health; // переменная для жизни
    private int maxHealth;

    void Start()
    {
        _health = 5;//инициализация переменной
        maxHealth = 100;
    }

    public void ChangeHealth(int value)
    {
        _health += value;
        if (_health > maxHealth)
        {
            _health = maxHealth;
        }else if (_health <0)
        {
            _health = 0;
        }
        Debug.Log("health:" + _health + "/" + maxHealth);
                
                }
   

    public void Hurt(int damage) 
    {
        _health -= damage;//уменьшение здоровья игрока
        Debug.Log("Health: " + _health);
    }

}
