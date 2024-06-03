using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
	[SerializeField] List<Transform> moveTargets;
	[SerializeField] private CharacterController controller;
	private int currentTargrtIndex = 0;
	private Vector3 moveDirection = Vector3.zero;

	void Start()
	{
		controller = this.gameObject.AddComponent<CharacterController>();
	}

	void Update()
	{
		transform.LookAt(moveTargets[currentTargrtIndex].transform);
		moveDirection = moveTargets[currentTargrtIndex].transform.position - transform.position;
		controller.SimpleMove(moveDirection * 0.5f);

		if (Vector3.Distance(transform.position, moveTargets[currentTargrtIndex].transform.position) < 1.5f)
		{
			currentTargrtIndex = (currentTargrtIndex + 1) % moveTargets.Count;
		}
	}
}
