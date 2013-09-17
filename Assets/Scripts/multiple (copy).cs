using UnityEngine;
using System.Collections;

public class multiplecopy : MonoBehaviour {
	
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	private GameObject myGameObject;
	
	void Start () 
	{	
		myGameObject = new GameObject();
		myGameObject.name = "name001";
		
		LineRenderer lr = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));	
		lr.SetWidth(0.4f, 0.4f);
		
		v3StartPosition.Set(0f, 0f, 0f);
		v3EndPosition.Set(20f, 0f, 0f);
		
		lr.SetPosition(0, v3StartPosition);
		lr.SetPosition(1, v3EndPosition);		
		


		myGameObject = new GameObject();
		myGameObject.name = "name002";		
		
		LineRenderer lr2 = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));
		lr2.SetWidth(0.4f, 0.4f);
		
		v3StartPosition.Set(0f, 10f, 0f);
		v3EndPosition.Set(20f, 10f, 0f);
		
		lr2.SetPosition(0, v3StartPosition);
		lr2.SetPosition(1, v3EndPosition);

	}

	void Update ()
	{	
	
	}
}
