using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
/*
* Author: me, duh :)
* Date: 20 may 2024 [abit late for submission im sorry :/]
* Description: door mehanic for player to pass by when they get close to it. works first time so i woudlnt touch it anymore UwU
*/
{
    /// <summary>
    ///door wont open unless and until user touches it
    /// </summary>

    bool opened = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !opened)
        {
            OpenDoor();
        }
    }

    //angle of door will change once player touhces it
    void OpenDoor()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y += 90f;
        transform.eulerAngles = newRotation;

        opened = true;
    }

}
