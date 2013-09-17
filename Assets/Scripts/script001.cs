using UnityEngine;
using System.Collections;

public class script001 : MonoBehaviour
{
	private GameObject myGameObject;
	private LineRenderer tempLineRenderer;
	private LineRenderer myLineRenderer;
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	
	private	int myObjectCount = 0;
	private string myObjectName;

	private float startPosX = 0f;
	private float startPosY = 0f;	
	private float endPosX = 10f;
	private float endPosY = 10f;
	
	private string currentDirection;
	
	void Start ()
	{		
		createNewObject();
	
		v3StartPosition.Set(startPosX, startPosY, 0f);
		v3EndPosition.Set(endPosX, endPosY, 0f);
	}

	void Update ()
	{	
			if (Input.GetKeyDown("space"))
			{
				createNewObject();			
				v3StartPosition.Set(endPosX, endPosY, 0f);
				changeDirection();
			}
		
		// Move current line right
			endPosX++;
		
		// Move current line up or down
			if (currentDirection == "up")
			{
				endPosY--;
			}
			else
			{
				endPosY++;
			}			

		
			v3EndPosition.Set(endPosX, endPosY, 0f);
			drawLine();
	}
	
	private void changeDirection()
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
	
	GameObject createNewObject()
	{
		myObjectName = "object" + myObjectCount.ToString();

		myGameObject = new GameObject();
		myGameObject.name = myObjectName;		
		myObjectCount++;
		
		tempLineRenderer = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));
		tempLineRenderer.SetWidth(0.4f, 0.4f);		
		
		return myGameObject;
	}
	
	void drawLine()
	{
		tempLineRenderer.SetPosition(0, v3StartPosition);
		tempLineRenderer.SetPosition(1, v3EndPosition);			
	}
}