using UnityEngine;
using System.Collections;

public class line005 : MonoBehaviour {
	
	private Vector3 v3StartPosition;
	private Vector3 v3CurrentPosition;
	private LineRenderer myLine;
	//private float screenWidth = 400;
	//private float screenHeight = 200;
	private string currentDirection;
	private int currentIndex = 0;
	private float currentX; 
	private float currentY;
	private float currentZ;
			
	// Use this for initialization
	void Start ()
	{
		// Get LineRenderer
		myLine = GetComponent<LineRenderer>();
		// Set start position
		v3StartPosition.Set(0f, 0f, 0f);
		myLine.SetPosition(0, v3StartPosition);
		// Set line width
		myLine.SetWidth(0.4f, 0.4f);
		// Set line colour
		myLine.SetColors(Color.white, Color.green);		
		
		// Set camera position
		Camera.main.ScreenToWorldPoint(v3StartPosition);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("space"))
		{	
			changeDirection(currentDirection);
			//LineRenderer myLine = new GameObject().AddComponent("LineRenderer") as LineRenderer;
			currentIndex++;
		}
			
		
		
		
		
		
		

		
		if (currentDirection == "up")
		{
			currentY--;
		}
		else
		{
			currentY++;
		}		
		
		currentX++;
		
		v3CurrentPosition.Set(currentX, currentY, 0);
		myLine.SetPosition(0, v3CurrentPosition);
		
	}
	
	private void changeDirection(string inDirection)
	{
		if (currentDirection == "up")
		{
			currentDirection = "down";
		}
		else
		{
			currentDirection = "up";
		}
	}
}
