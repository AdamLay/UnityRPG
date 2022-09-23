using System;
using UnityEngine;

public class Health : MonoBehaviour
{
	[SerializeField]
	private int Value;

	public int MaxValue;

	public Action<int, Health> OnChanged;
	public Action<Health> OnKilled;

	private void Start()
	{
		ModifyValue(MaxValue);
	}

	public int ModifyValue(int amount)
	{
		Value += amount;
		OnChanged?.Invoke(Value, this);
		return Value;
	}

	void Update()
	{
		if (Value <= 0)
			OnKilled?.Invoke(this);
	}
}
