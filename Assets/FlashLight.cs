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
			energy = Mathf.Clamp(energy, 0, 100);
		}

		// blinking on low battery
		if (energy < 50f)
		{
			light.intensity = Random.Range(0.5f, 1f);
		}

		if (energy <= 0)
		{
			enabled = false;
		}
	}
}