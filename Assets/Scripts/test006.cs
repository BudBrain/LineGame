using UnityEngine;
using System.Collections;

public class test006 : MonoBehaviour
{
	private GameObject myGameObject;
	private LineRenderer myLineRenderer;
	
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	
	//private float myX = 20;
	//private float myY = 20;

	// Use this for initialization
	void Start ()
	{
		myGameObject = new GameObject();
		myGameObject.name = "object001";		
	
		v3StartPosition.Set(0f, 0f, 0f);
		v3EndPosition.Set(10f, 10f, 0f);
		
		myLineRenderer = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));	
		myLineRenderer.SetWidth(0.4f, 0.4f);
		myLineRenderer.SetPosition(0, v3StartPosition);
		myLineRenderer.SetPosition(1, v3EndPosition);	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//myX = myX + 10;
		//myY = myY + 10;
		
		//Debug.Log(myX);
		
		myGameObject = GameObject.Find("myGameObject");
		
		myLineRenderer = myGameObject.GetComponent<LineRenderer>();
		
		
		
		v3StartPosition.Set(20f, 20f, 0f);
		v3EndPosition.Set(30f, 30f, 0f);
		
		myLineRenderer.SetWidth(0.4f, 0.4f);
		myLineRenderer.SetPosition(0, v3StartPosition);
		myLineRenderer.SetPosition(1, v3EndPosition);
	}
}
