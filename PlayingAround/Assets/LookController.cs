using UnityEngine;
using System.Collections;

public class LookController : MonoBehaviour
{
	public Transform target;
	
	void Update ()
	{
		transform.LookAt(target);
	}
}
