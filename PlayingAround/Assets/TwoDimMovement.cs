using UnityEngine;
using System.Collections;

public class TwoDimMovement : MonoBehaviour
{
	public float speed;
	
	void FixedUpdate ()
	{
		if(Input.GetKey(KeyCode.UpArrow))
			this.rigidbody.AddForce(this.transform.forward * speed * Time.fixedDeltaTime);
			//this.transform.position += this.transform.forward * speed * Time.fixedDeltaTime;
		
		if(Input.GetKey(KeyCode.DownArrow))
			this.rigidbody.AddForce(-this.transform.forward * speed * Time.fixedDeltaTime);
			//this.transform.position -= this.transform.forward * speed * Time.fixedDeltaTime;
		
		if(Input.GetKey(KeyCode.RightArrow))
			this.rigidbody.AddForce(this.transform.right * speed * Time.fixedDeltaTime);
			//this.transform.position += this.transform.right * speed * Time.fixedDeltaTime;
		
		if(Input.GetKey(KeyCode.LeftArrow))
			this.rigidbody.AddForce(-this.transform.right * speed * Time.fixedDeltaTime);
			//this.transform.position -= this.transform.right * speed * Time.fixedDeltaTime;
	}
}
