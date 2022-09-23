using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	[SerializeField]
	private int ScoreValue = 1;

	private Health _health;

	// Start is called before the first frame update
	void Start()
	{
		_health = GetComponent<Health>();

		_health.OnKilled += OnKilled;
	}

	internal void TakeDamage(int damage)
	{
		_health.ModifyValue(-damage);
	}

	private void OnKilled(Health _)
	{
		// Some kind of effect?

		GameManager.Instance.AddScore(ScoreValue);

		Destroy(gameObject);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
