using UnityEngine;

public class Monster : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
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