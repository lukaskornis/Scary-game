using UnityEngine;

public class FlashLight : MonoBehaviour
{
	Light light;
	public float energy = 100;
	public float dischargeSpeed = 1;

	void Start()
	{
		light = GetComponentInChildren<Light>();
	}


	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			light.enabled = !light.enabled;
		}

		if (light.enabled)
		{
			energy -= Time.deltaTime * dischargeSpeed;
		}

		// blinking on low battery
	}
}