using UnityEngine;
using System.Collections;

public class multipleold : MonoBehaviour {
	
	private Vector3 v3StartPosition;
	private Vector3 v3EndPosition;
	private GameObject myGameObject;
	
	void Start () 
	{	


	}

	void Update ()
	{	
		v3StartPosition.Set(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F), 0f);
		v3EndPosition.Set(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F), 0f);		

		if (Input.GetKeyDown("space"))
		{	
			createNewLine(v3StartPosition, v3EndPosition);
		}
	}
	
	void createNewLine(Vector3 inStartPos, Vector3 inEndPos)
	{
		myGameObject = new GameObject();
		
		LineRenderer lr = (LineRenderer)myGameObject.AddComponent(typeof(LineRenderer));	
		lr.SetWidth(0.4f, 0.4f);
		
		lr.SetPosition(0, inStartPos);
		lr.SetPosition(1, inEndPos);			
	}
}
