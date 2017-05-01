using UnityEngine;
using System.Collections;

public class LookAtConstraint : MonoBehaviour 
{
	public Transform target;

	void Update () 
	{
		transform.LookAt(target);
	}
}
