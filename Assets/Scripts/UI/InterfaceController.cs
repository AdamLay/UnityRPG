using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InterfaceController : MonoBehaviour
{
	public Health PlayerHealth;

	private Label _healthValue;
	// Start is called before the first frame update
	void Start()
	{
		var uiDocument = GetComponent<UIDocument>();

		_healthValue = uiDocument.rootVisualElement.Q("HealthGroup").Q<Label>("HealthValue");

		PlayerHealth.OnChanged += OnHealthChanged;
	}

	void OnHealthChanged(int value, Health health)
	{
		_healthValue.text = $"{value}/{health.MaxValue}";
	}

	// Update is called once per frame
	void Update()
	{

	}
}
