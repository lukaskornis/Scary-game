using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public float viewDistance = 10f;
	public float forgetDistance = 12f;
	public float scareDistance = 3f;
	public float patrolDistance = 10;
	public float patrolInterval = 2f;
	public Transform target;
	NavMeshAgent agent;
	Vector3 randomPoint;


	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		InvokeRepeating(nameof(RandomPoint),0f,patrolInterval);
		randomPoint = transform.position;
	}


	void RandomPoint()
	{
		randomPoint += Random.insideUnitSphere * patrolDistance;
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
		else
		{
			agent.SetDestination(randomPoint);
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