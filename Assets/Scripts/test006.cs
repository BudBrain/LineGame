using UnityEngine;
using System.Collections;

public class test006 : MonoBehaviour
{
	private GameObject myGameObject;
	private LineRenderer myLineRenderer;
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	
	private	int myObjectCount = 0;
	private string myObjectName;
	
	private float myX = 10f;
	private float myY = 10f;
	
	void Start ()
	{		
		createNewObject();
	
		v3StartPosition.Set(0f, 0f, 0f);
		v3EndPosition.Set(myX, myY, 0f);
		
		myLineRenderer = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));	
		myLineRenderer.SetWidth(0.4f, 0.4f);
		myLineRenderer.SetPosition(0, v3StartPosition);
		myLineRenderer.SetPosition(1, v3EndPosition);	
		
				Debug.Log("start");
	}

	void Update ()
	{
		myX++;
		myY++;
		
		if (Input.GetKeyDown("space"))
		{
			GameObject tempObject = createNewObject();			
			LineRenderer myLineRenderer = (LineRenderer)tempObject.AddComponent(typeof(LineRenderer));
			myLineRenderer.SetWidth(0.4f, 0.4f);
			v3StartPosition.Set(myX, myY, 0f);
		}	
		
		v3EndPosition.Set(myX, myX, 0f);
		myLineRenderer.SetPosition(0, v3StartPosition);
		myLineRenderer.SetPosition(1, v3EndPosition);
	}
	
	GameObject createNewObject()
	{
		myObjectName = "object" + myObjectCount.ToString();

		myGameObject = new GameObject();
		myGameObject.name = myObjectName;		
		myObjectCount++;
		
		return myGameObject;
	}
}