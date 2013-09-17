using UnityEngine;
using System.Collections;

/// <summary>
/// Line Wave v0.8
/// Use with Unity's LineRenderer
/// by Adriano Bini.
/// </summary>

public class lineWave : MonoBehaviour {
	float ampT;
	public int size;
	public float lengh;
	public float freq;
	public float amp;
	public bool ampByFreq;
	public bool centered;
	public bool centCrest;
	public bool warp;
	public bool warpInvert;
	public float warpRandom;
	public float walkManual;
	public float walkAuto;
	public bool spiral;
	float warpT;
	float angle;
	float sinAngle;
	float sinAngleZ;
	double walkShift;
	Vector3 posVtx2;
	Vector3 posVtxSizeMinusOne;
	LineRenderer lrComp;
	
	void Start () {
	}
	
	void Update () {
		lrComp = GetComponent<LineRenderer>();
		
		if (warpRandom<=0){warpRandom=0;}
		if (size<=2){size=2;}
		lrComp.SetVertexCount(size);
		
		if (ampByFreq) {ampT = Mathf.Sin(freq*Mathf.PI);}
		else {ampT = 1;}
		ampT = ampT * amp;
		if (warp && warpInvert) {ampT = ampT/2;}
		
		for (int i = 0; i < size; i++) {
			angle = (2*Mathf.PI/size*i*freq);
			if (centered) {
				angle -= freq*Mathf.PI; 	//Center
				if (centCrest) {
					angle -= Mathf.PI/2;	//Crest/Knot
				}
			}
			else {centCrest = false;}
			
			walkShift += walkAuto/10000;
			angle += (float)walkShift + walkManual;
			sinAngle = Mathf.Sin(angle);
			if (spiral) {sinAngleZ = Mathf.Cos(angle);}
			else {sinAngleZ = 0;}
			
			if (warp) {
				warpT = size - i;
				warpT = warpT / size;
				warpT = Mathf.Sin(Mathf.PI * warpT * (warpRandom+1));
				if (warpInvert) {warpT = 1/warpT;}
				lrComp.SetPosition(
					i, new Vector3(lengh/size*i - lengh/2, sinAngle * ampT * warpT, sinAngleZ * ampT * warpT));
			}
			else {lrComp.SetPosition(
					i, new Vector3(lengh/size*i - lengh/2, sinAngle * ampT, sinAngleZ * ampT));
					warpInvert = false;
			}
			
			if (i == 1) {posVtx2 = new Vector3(lengh/size*i - lengh/2, sinAngle * ampT * warpT, sinAngleZ * ampT * warpT);}
			if (i == size-1) {posVtxSizeMinusOne = new Vector3(lengh/size*i - lengh/2, sinAngle * ampT * warpT, sinAngleZ * ampT * warpT);}
		}
		
		if (warpInvert) {  //Fixes pinned limits when WarpInverted
			lrComp.SetPosition(0, posVtx2);
			lrComp.SetPosition(size-1, posVtxSizeMinusOne);
		}
	}
}
