using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
	private bool isGameOver = true;

	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// If all four goals are solved then the game is over
		isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

	private void OnGUI()
	{
		if (isGameOver)
		{
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);		//Set gui to middle of screen
			GUI.Box (rect, "Game Over");															//Puts "Game Over" in center of screen
			
			Rect rect2 = new Rect (Screen.width /2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Box (rect2, "Good Job!");
		}
	}
}
