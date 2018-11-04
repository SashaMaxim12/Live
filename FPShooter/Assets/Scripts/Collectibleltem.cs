using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibleltem : MonoBehaviour {

    public string itemName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected:" + itemName);
        Destroy(this.gameObject);
        if(itemName == "health")
        {
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if(player != null)
            {
                player.ChangeHealth(20);
            }
        }
    }


}
