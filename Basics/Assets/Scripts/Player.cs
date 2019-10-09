using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	[Header("Player Settings")]
	[SerializeField] float m_speed;

	[Header("UI")] 
	[SerializeField] Text m_scoreText;
	
	Rigidbody m_rb;
	int m_currentScore;

	private void Awake()
	{
		m_rb = GetComponent<Rigidbody>();
		SetScoreText();
	}
	
	private void Move(Vector3 direction)
	{
		m_rb.AddForce(m_speed * direction * Time.deltaTime, ForceMode.Impulse);
	}
	
	public void MoveForwards()
	{
		Move(Vector3.forward);
	}
	
	public void MoveBackwards()
	{
		Move(Vector3.back);
	}
	
	public void MoveLeft()
	{
		Move(Vector3.left);
	}
	
	public void MoveRight()
	{
		Move(Vector3.right);
	}

	private void Update()
	{
		/*if(Input.GetKeyDown(KeyCode.W))
		{
			MoveForwards();
		}
		else if(Input.GetKeyDown(KeyCode.S))
		{
			MoveBackwards();
		}
		else if(Input.GetKeyDown(KeyCode.A))
		{
			MoveLeft();
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			MoveRight();
		}*/
	}
	
	public void AddScore(int score = 1)
	{
		m_currentScore += score;
		SetScoreText();
	}

	private void SetScoreText()
	{
		if (m_scoreText != null)
		{
			m_scoreText.text = m_currentScore.ToString();
		}
	}

}
