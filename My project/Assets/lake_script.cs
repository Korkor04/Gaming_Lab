using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lake_script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Player")
    //if the collider of the object whose name is Sonic GameObjects touches the spike collider
    {
        FindObjectOfType<manager_script>().RespawnPlayer();
        //go to the Level Manager script, and execute the Respawn Player function
    }
}
}
