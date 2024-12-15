using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public float viewDistance = 10;
    public Transform target;
    public float speed = 2;
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
        else
        {

        }


        if (distance < 3)
        {
            float angle = Vector3.Angle(transform.forward, target.transform.forward);
            if (angle > 160f)
            {
                print("boo");
            }
        }
    }
}