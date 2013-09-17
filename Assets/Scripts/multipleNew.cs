using UnityEngine;
using System.Collections;

public class multipleNew : MonoBehaviour {
	
	string myObjectName;
	private GameObject myGameObject;
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;	
	
	private string currentDirection = "up";
	int myObjectCount = 0;
	float currentX = 0;
	float currentY = 0;
	
	void Start () 
	{	
		Debug.Log("Started!");
		createNewObject();
		drawLine();
	}

	void Update ()
	{	
		if (Input.GetKeyDown("space"))
		{	
			changeDirection(currentDirection);
		}
			
		currentX++;
		
		if (currentDirection == "up")
		{
			currentY--;
		}
		else
		{
			currentY++;
		}
		
		drawLine();
	}
	
	GameObject createNewObject()
	{
		myObjectName = "object" + myObjectCount.ToString();

		myGameObject = new GameObject();
		myGameObject.name = myObjectName;		
		myObjectCount++;
		
		return myGameObject;
	}
	
	void drawLine()
	{
		GameObject tempObject = createNewObject();
		
		v3StartPosition.Set(currentX, currentY, 0f);
		v3EndPosition.Set(currentX, currentY, 0f);	
			
		LineRenderer lr = (LineRenderer)tempObject.AddComponent(typeof(LineRenderer));	
		lr.SetWidth(0.4f, 0.4f);
		lr.SetPosition(0, v3StartPosition);
		//lr.SetPosition(1, v3EndPosition);
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