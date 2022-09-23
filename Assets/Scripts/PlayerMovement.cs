using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public int Speed = 1;

	private KeyCode _forwards = KeyCode.W;
	private KeyCode _backwards = KeyCode.S;
	private KeyCode _left = KeyCode.A;
	private KeyCode _right = KeyCode.D;
	private Rigidbody2D _rb;

	private void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 input = Vector2.zero;

		if (Input.GetKey(_forwards))
		{
			input += Vector2.up * Speed;
		}
		if (Input.GetKey(_backwards))
		{
			input += Vector2.down * Speed;
		}
		if (Input.GetKey(_left))
		{
			input += Vector2.left * Speed;
		}
		if (Input.GetKey(_right))
		{
			input += Vector2.right * Speed;
		}

		_rb.velocity = input;
	}
}
