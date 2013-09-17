using UnityEngine;
using System.Collections;

public class multiple : MonoBehaviour {
	
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	private GameObject myGameObject;
	private LineRenderer myLine;
	
	private float lineWidthX = 0.4f;
	private float lineWidthY = 0.4f; 
	
	private float myStartX = 0f;
	private float myStartY = 0f;
	
	private float myEndX = 10f;
	private float myEndY = 10f;
	
	private int myLineNumber = 0;
	private string myLineName;
	
	void Start () 
	{	
		v3StartPosition.Set(myStartX, myStartY, 0f);
		v3EndPosition.Set(myEndX, myEndY, 0f);
			
		createNewLine(v3StartPosition, v3EndPosition);
	}

	void Update ()
	{	
		if (Input.GetKeyDown("space"))
		{	
			createNewLine(v3StartPosition, v3EndPosition);
		}
		
		v3StartPosition.Set(myStartX, myStartY, 0f);
		v3EndPosition.Set(myEndX, myEndY, 0f);
		
		//myLineName.SetPosition(0, v3EndPosition);
		
	}
	
	void createNewLine(Vector3 inStartPos, Vector3 inEndPos)
	{	
		myLineName = "myLineName" + myLineNumber.ToString();
		Debug.Log(myLineName);
		
		myGameObject = new GameObject();
		myGameObject.name = myLineName;
		
		LineRenderer lr = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));	
		lr.SetWidth(lineWidthX, lineWidthY);
		
		lr.SetPosition(0, inStartPos);		
		lr.SetPosition(1, inEndPos);
		
		myLineNumber++;
	}
	
	
}
