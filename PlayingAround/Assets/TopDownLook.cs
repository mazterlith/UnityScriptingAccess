using UnityEngine;
using System.Collections;

public class TopDownLook : MonoBehaviour
{
	public Transform target;
	
	void Update ()
	{
		//On update, change the x and z coordinates to whatever the target's is, but keep the y coordinate.
		this.transform.position = new Vector3(target.position.x, this.transform.position.y, target.position.z);
	}
}
