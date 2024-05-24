using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
/*
* Author: me, duh :)
* Date: 20 may 2024 [abit late for submission im sorry :/]
* Description: collectible script to increase the score of player
*/
{
    /// <summary>
    /// object will be detroyed upon touching it, score will increase
    /// </summary>

     int myScore = 10;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);

            Debug.Log("wow! i got collected!");
            Destroy(gameObject);

        }
    }
    //i try using this method bbut something went wrong, im sorry
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //checks if player touched the collectible
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
    //        Debug.Log("wow! i got collected!");
    //        Destroy(gameObject);
    //    }
    //}

}
