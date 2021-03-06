﻿using UnityEngine;
using System.Collections;

public class script002 : MonoBehaviour
{
	private float startPosX = 0f;
	private float startPosY = 0f;	
	private float endPosX = 1f;
	private float endPosY = 0f;
	private GameObject myGameObject;	
	private	int myObjectCount = 0;
	private LineRenderer myLineRenderer;
	private string currentDirection;
	private string myObjectName;
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;	
	
	void Start ()
	{		
		v3StartPosition.Set(startPosX, startPosY, 0f);
		v3EndPosition.Set(endPosX, endPosY, 0f);
		randomiseStartDirection();
		
		createNewObject();
		drawLine();
	}
	
	void randomiseStartDirection()
	{
		int tempNum = Random.Range(0, 2);
		
		if (tempNum == 0) { currentDirection = "up"; }
		else { currentDirection = "down"; }
	}

	void Update ()
	{
		// On "space bar" press...
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

		// Set end position of line
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
		
		myLineRenderer = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));
		myLineRenderer.SetWidth(0.4f, 0.4f);		
		
		return myGameObject;
	}
	
	void drawLine()
	{
		myLineRenderer.SetPosition(0, v3StartPosition);
		myLineRenderer.SetPosition(1, v3EndPosition);			
	}
}