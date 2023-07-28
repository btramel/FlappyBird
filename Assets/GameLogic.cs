using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;

    [ContextMenu("IncreaseScore")]
   public void addScore(int scoreToAdd) {
    playerScore = playerScore + scoreToAdd;
    scoreText.text = playerScore.ToString();
   }
}
