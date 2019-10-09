using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	[SerializeField] Transform player;

	Vector3 m_offset;

	private void Awake()
	{
		m_offset = transform.position;
	}
	
	private void Update()
	{
		transform.position = player.position + m_offset;
	}
}
