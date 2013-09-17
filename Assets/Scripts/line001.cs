using UnityEngine;
using System.Collections;

public class line001 : MonoBehaviour {

	
	
	
	private LineRenderer lineRenderer;
	private float counter;
	private float dist;
	private int ypos = 1;
	
	//public Transform origin;
	//public Transform destination;
	
	public Vector3 origin;
	public Vector3 destination;
	
	public float lineDrawSpeed = 6f;
	
	

	// Use this for initialization
	void Start ()
	{
		
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetPosition(0, origin);
		lineRenderer.SetWidth(0.45f, 0.45f);
		
		dist = Vector3.Distance(origin, destination);
	}
	
	// Update is called once per frame
	void Update ()
	{		
		if (counter < dist)
		{
			counter += .1f / lineDrawSpeed;
			
		if (Input.GetMouseButtonDown(0))
		{
            Debug.Log("Pressed left click.");
				ypos++;
			}
			
			
			float x = Mathf.Lerp(0, dist, counter);
			
			Vector3 pointA = origin;
			Vector3 pointB = destination;
			
			Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
			
			lineRenderer.SetPosition(ypos, pointAlongLine);
		}
	}
	
	
	
	
	
	
	
}
