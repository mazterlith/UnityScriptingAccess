using UnityEngine;
using System.Collections;

public class GravityPull : MonoBehaviour
{
	public Transform gravityCenter;
	public float cutOffDistance;
		
	void FixedUpdate ()
	{
		if(gravityCenter.localPosition.magnitude < cutOffDistance)
			Debug.Log("Poo.");//Gravity Behavior
	}
}
