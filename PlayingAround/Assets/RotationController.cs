using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour
{
	public float rotateSpeed = 10.0f;
	public float lookSpeed = 10.0f;

	void Update ()
	{
		if(Input.GetKey(KeyCode.U))
			transform.Rotate(Vector3.right, -lookSpeed * Time.deltaTime);
		else if(Input.GetKey(KeyCode.J))
			transform.Rotate(Vector3.right, lookSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.H))
			transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
		else if(Input.GetKey(KeyCode.K))
			transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
