using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float scareDistance = 3f;
	public Transform target;

	void Update()
	{
		float distance = Vector3.Distance(transform.position, target.position);

		if (distance < scareDistance)
		{
			JumpScare();
			enabled = false;
		}
	}

	void JumpScare()
	{
		print( "Jump Scare!" );
	}
}