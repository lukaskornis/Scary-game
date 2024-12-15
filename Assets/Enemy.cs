using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public float viewDistance = 10f;
	public float scareDistance = 3f;
	public Transform target;
	NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, viewDistance);
	}


	void Update()
	{
		float distance = Vector3.Distance(transform.position, target.position);

		if (distance < viewDistance)
		{
			agent.SetDestination(target.position);
		}

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