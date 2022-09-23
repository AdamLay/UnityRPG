using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	private int Score;

	public static GameManager Instance { get; private set; }

	// Start is called before the first frame update
	void Start()
	{
		Instance = this;
	}

	public void AddScore(int score)
	{
		Score += score;
	}

	// Update is called once per frame
	void Update()
	{
		var time = Time.deltaTime;
	}
}
