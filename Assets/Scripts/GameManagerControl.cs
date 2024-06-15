using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public Text pointsText;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        IncreasePoints(0); 
    }
    public void IncreasePoints(int pointsToAdd)
    {
        points = points + pointsToAdd;
        pointsText.text = "PUNTOS: " + points;
    }
}
