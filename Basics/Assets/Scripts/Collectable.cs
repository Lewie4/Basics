using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
	[SerializeField] int score = 1;

	void Update()
	{
		transform.eulerAngles += Vector3.up * 30 * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.gameObject.GetComponent<Player>().AddScore(score);
			Destroy(this.gameObject);
		}
	}
}
