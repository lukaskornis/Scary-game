using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light light;
    public float dischargeSpeed = 1;
    public float energy = 100;

    void Start()
    {
        light = GetComponentInChildren<Light>();
        light.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && energy > 0f)
        {
            light.enabled = !light.enabled;
        }

        if (light.enabled)
        {
            energy -= Time.deltaTime * dischargeSpeed;
        }

        if (energy < 50f)
        {
            light.intensity = Random.Range(0.8f, 1f);
        }

        if (energy < 0f)
        {
            light.enabled = false;
            energy = 0f;
        }
    }
}