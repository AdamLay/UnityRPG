using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Health _health;

	// Start is called before the first frame update
	void Start()
	{
		_health = GetComponent<Health>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			_health.ModifyValue(-1);
		}
	}
}
