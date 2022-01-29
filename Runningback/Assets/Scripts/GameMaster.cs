using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Goal")
        {
            Debug.Log("The game has ended");
        }
    }
}
