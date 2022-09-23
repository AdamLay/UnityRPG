using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	[SerializeField]
	private Collider2D WeaponCollider;

	[SerializeField]
	private int Range;

	[SerializeField]
	private int Damage;

	// Start is called before the first frame update
	void Start()
	{
		_enemyMask = LayerMask.GetMask("Enemies");
	}

	private KeyCode _attackKey = KeyCode.Space;
	private int _enemyMask;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(_attackKey))
		{
			// Do attack
			var hits = Physics2D.CircleCastAll(Vector2.zero, Range, Vector2.zero, Mathf.Infinity, layerMask: _enemyMask);

			foreach (var hit in hits)
			{
				var enemy = hit.transform.GetComponent<EnemyController>();
				if (enemy is not null)
				{
					enemy.TakeDamage(Damage);
				}
			}
		}
	}
}
