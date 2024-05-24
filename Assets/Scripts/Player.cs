using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Rendering;


public class Player : MonoBehaviour
/*
* Author: me, duh :)
* Date: 20 may 2024 [abit late for submission im sorry :/]
* Description: just some basic ui for the game and when the player has collected 5 items, keeps track of the score
*/

{
    public TextMeshProUGUI scoreText;
    public GameObject MessageBox;

    public int currentScore = 0;

    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        Debug.Log(currentScore);
        scoreText.text = currentScore.ToString();
        MessageBox.SetActive(true);
    }
}
