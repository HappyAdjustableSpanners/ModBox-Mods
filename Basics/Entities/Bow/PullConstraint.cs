using UnityEngine;
using System.Collections;

public class PullConstraint : MonoBehaviour 
{
	public Transform target;
	public float copyPercentage;
	private Vector3 startPos;

	void Start () 
	{
		startPos = transform.localPosition;
	}

	void Update () 
	{
		transform.localPosition = Vector3.Lerp(startPos,target.localPosition,copyPercentage);
	}
}
